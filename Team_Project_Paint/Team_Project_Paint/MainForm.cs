using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Team_Project_Paint.Class;
using Team_Project_Paint.Class.OperationWithFigures;
using Team_Project_Paint.PaintEnum;
using Team_Project_Paint.Interfaces;
using Team_Project_Paint.Class.FigureDrawingClass;
using System.IO;

namespace Team_Project_Paint
{
    public partial class Paint : Form
    {
        private PaintColor _curentcolor = new PaintColor(0, 0, 0);
        private int _currentBrashSize = 1;
        private ShapePoint _lastPonit;
        private EShapeType _currentMode;
        private PaintBitmap _currentBitmap;
        private PaintBitmap _bufferedBitmap;
        private bool _isMoveMode = false;
        private bool _isSelectMode = false;
        private bool _isStartMove = false;
        private bool _isSelected = false;
        private BusinessLogic _bl;
        private int _cornesValue;


        public Paint()
        {
            InitializeComponent();
            _currentMode = EShapeType.Curve;

            _bl = new BusinessLogic(new Storage(), new ShapeFactory(), new JsonLogic());
            _bl.Init(_currentMode, _currentBrashSize, _curentcolor);

            _currentBitmap = new PaintBitmap(pictureBoxMain.Width, pictureBoxMain.Height);
            _bufferedBitmap = _currentBitmap.Clone() as PaintBitmap;
            pictureBoxMain.Image = _currentBitmap.ToImage();
        }

        private void Repaint()
        {
            if (_bl.GetBoolCount())
            {
                // Достаем последнюю фигуру, ту, которая в данный момент рисуется
                IShape currentShape = _bl.Last();
                // Создаем буфферный битмап для рисования, через клонирование основного
                _bufferedBitmap = _currentBitmap.Clone() as PaintBitmap;
                // Создем холс для рисования, на основе буфферного битмапа,
                // На котором уже нарисовано все, что было нарисовано ранее, благодары клонированию
                // из основного битмапа (_bufferedBitmap = _currentBitmap.Clone() as Bitmap;)
                PaintGraphics _bufferedGraphics = PaintGraphics.FromImage(_bufferedBitmap);
                // Просим текущую фигуру ДОРИСОВАТЬ себя на холсте, на котором уже много чего нарисовано
                currentShape.Draw(_bufferedGraphics);
                // Если фигура все-еще рисуется, показать ее на экране (обновить)
                if (currentShape.EShapeStatus == EShapeStatus.IN_PROGRESS)
                {
                    pictureBoxMain.Image = _bufferedBitmap.ToImage();
                }
                if (currentShape.EShapeStatus == EShapeStatus.DONE)
                {
                    _currentBitmap = _bufferedBitmap.Clone() as PaintBitmap;
                    pictureBoxMain.Image = _currentBitmap.ToImage();
                }
            }
        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (!_isSelectMode && !_isMoveMode && e.Button == MouseButtons.Left)
            {
                var hexSize = new ShapeSize(pictureBoxMain.Size);
                _bl.NewShape(_currentMode, _currentBrashSize, _curentcolor, _cornesValue, hexSize);
                _bl.Last().MouseDown(new ShapePoint(e.Location));

                Repaint();
            }
            else if (_isSelectMode && !_isStartMove && e.Button == MouseButtons.Left)
            {
                _lastPonit = new ShapePoint(e.Location);
                _isSelected = _bl.SelectShape(_lastPonit);

                if (_isSelected && _isMoveMode)
                {
                    _isStartMove = true;
                    IShape currentShape = _bl.IsSelectShape();
                    _currentBitmap = new PaintBitmap(pictureBoxMain.Width, pictureBoxMain.Height);
                    Repaint();
                    _bl.UpdatePicture(_currentBitmap);
                    currentShape.EShapeStatus = EShapeStatus.IN_PROGRESS;
                    _bl.AddSelectShape(currentShape);
                    Repaint();
                }
            }
        }

        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (!_isStartMove && !_isSelectMode && !_isMoveMode &&  e.Button == MouseButtons.Left)
            {
                if (_bl.GetBoolCount())
                {
                    IShape currentShape = _bl.Last();
                    currentShape.MouseUp(new ShapePoint(e.Location));
                    Repaint();
                }
            }
            else if (_isStartMove && e.Button == MouseButtons.Left)
            {
                IShape currentShape = _bl.Last();
                _bl.Move(e.X - _lastPonit.X, e.Y - _lastPonit.Y, currentShape);
                currentShape.Draw(PaintGraphics.FromImage(_currentBitmap));
                if (currentShape.Name == EShapeType.Dot)
                {
                    currentShape.EShapeStatus = EShapeStatus.DONE;
                    Repaint();
                }

                _isStartMove = false;
                _isSelected = false;
            }
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (_isMoveMode && _isStartMove)
                {
                    IShape currentShape = _bl.Last();
                    _bl.Move(e.X - _lastPonit.X, e.Y - _lastPonit.Y, currentShape);
                    _lastPonit = new ShapePoint(e.Location);
                    Repaint();

                }
                else if (!_isMoveMode && !_isSelectMode && _bl.GetBoolCount())
                {
                    IShape currentShape = _bl.Last();
                    currentShape.MouseMove(new ShapePoint(e.Location));
                    Repaint();

                }
            }
        }

        private void PictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && !_isSelectMode && !_isMoveMode)
            {
                if (_bl.GetBoolCount())
                {
                    IShape currentShape = _bl.Last();
                    currentShape.MouseClick(new ShapePoint(e.Location));
                    Repaint();
                }
            }
        }

        private void DotButton_Click(object sender, EventArgs e)
        {
            _currentMode = EShapeType.Dot;
        }

        private void LineButton_Click(object sender, EventArgs e)
        {
            _currentMode = EShapeType.Line;
        }

        private void CurveButton_Click(object sender, EventArgs e)
        {
            _currentMode = EShapeType.Curve;
        }

        private void RectangleButton_Click(object sender, EventArgs e)
        {
            _currentMode = EShapeType.Rect;
        }

        private void EllipseButton_Click(object sender, EventArgs e)
        {
            _currentMode = EShapeType.Ellipse;
        }
        private void TriangleButton_Click(object sender, EventArgs e)
        {
            _currentMode = EShapeType.Triangle;
        }
        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            _currentMode = EShapeType.Hexagon;
        }

        private void RoundingRectButton_Click(object sender, EventArgs e)
        {
            _currentMode = EShapeType.RoundingRect;
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            _bl.Clear();
            _currentBitmap = new PaintBitmap(pictureBoxMain.Width, pictureBoxMain.Height);
            _bufferedBitmap = _currentBitmap.Clone() as PaintBitmap;
            pictureBoxMain.Image = _currentBitmap.ToImage();
            Repaint();
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            CurrentColorButton.BackColor = b.BackColor;
            _curentcolor = new PaintColor(CurrentColorButton.BackColor);

            if (_bl.GetBoolCount() && _isSelected)
            {
                _currentBitmap = new PaintBitmap(pictureBoxMain.Width, pictureBoxMain.Height);
                pictureBoxMain.Image = _currentBitmap.ToImage();
                _bl.ChangeFigureColor(_currentBitmap, _curentcolor);
            }


        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|PNG Image|*.png|JSON File|*.json";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "" && saveFileDialog1.FilterIndex == 4)
            {
                _bl.JsonSave(saveFileDialog1.FileName);
            }
            else if (saveFileDialog1.FileName != "")
            {
                _currentBitmap.Save(saveFileDialog1.FileName);
            }
        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            _currentBrashSize = trackBar1.Value;
            numericUpDown1.Value = _currentBrashSize;
            if (_bl.GetBoolCount() && _isSelected)
            {
                _currentBitmap = new PaintBitmap(pictureBoxMain.Width, pictureBoxMain.Height);
                pictureBoxMain.Image = _currentBitmap.ToImage();
                _bl.ChanhgeFirgureThickness(_currentBitmap, _currentBrashSize);
            }
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            _currentBrashSize = (int)numericUpDown1.Value;
            trackBar1.Value = _currentBrashSize;
            if (_bl.GetBoolCount() && _isSelected)
            {
                _currentBitmap = new PaintBitmap(pictureBoxMain.Width, pictureBoxMain.Height);
                pictureBoxMain.Image = _currentBitmap.ToImage();
                _bl.ChanhgeFirgureThickness(_currentBitmap, _currentBrashSize);
            }
        }

        private void OpentoolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|PNG Image|*.png|JSON File|*.json";
            openFileDialog1.ShowDialog();

            if (openFileDialog1.FileName != "" && openFileDialog1.FilterIndex == 4)
            {

                var strings = File.ReadAllText(openFileDialog1.FileName);

                if (_bl.JsonOpen(strings, _currentBitmap))
                {
                    Repaint();
                }
            }
            else if (openFileDialog1.FileName != "")
            {
                _currentBitmap = (PaintBitmap)PaintImage.FromFile(openFileDialog1.FileName);
                pictureBoxMain.Image = _currentBitmap.ToImage();
                Repaint();
            }


        }

        private void ChengeColorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                CurrentColorButton.BackColor = colorDialog1.Color;
                _curentcolor = new PaintColor(colorDialog1.Color);
            }

            if (_bl.GetBoolCount() && _isSelected)
            {
                _currentBitmap = new PaintBitmap(pictureBoxMain.Width, pictureBoxMain.Height);
                pictureBoxMain.Image = _currentBitmap.ToImage();
                _bl.ChangeFigureColor(_currentBitmap, _curentcolor);
            }
        }

        private void NumericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            _cornesValue = decimal.ToInt32(numericUpDown2.Value);
            if (_bl.GetBoolCount())
            {
                IShape currentShape = _bl.Last();
                if (currentShape is Hexagon)
                {
                    (currentShape as Hexagon).Cornes = decimal.ToInt32(numericUpDown2.Value);
                }
            }
        }

        private void MoveBtn_Click(object sender, EventArgs e)
        {
            if (!_isMoveMode)
            {
                _isMoveMode = true;
                moveBtn.Text = "MOVE ON";
                deleteBtn.Enabled = false;
            }
            else
            {
                _isMoveMode = false;
                moveBtn.Text = "MOVE OFF";
                deleteBtn.Enabled = true;
            }
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            if (!_isSelectMode)
            {
                _isSelectMode = true;
                selectBtn.Text = "SELECT ON";
                moveBtn.Enabled = true;
                deleteBtn.Enabled = true;
            }
            else
            {
                _isSelectMode = false;
                _isMoveMode = false;
                moveBtn.Text = "MOVE OFF";
                selectBtn.Text = "SELECT OFF";
                moveBtn.Enabled = false;
                deleteBtn.Enabled = false;
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (_bl.GetBoolCount() && _isSelected)
            {
                _currentBitmap = new PaintBitmap(pictureBoxMain.Width, pictureBoxMain.Height);
                pictureBoxMain.Image = _currentBitmap.ToImage();
                _bl.Delete(_currentBitmap);
                _isSelected = false;
            }
        }
    }
}
