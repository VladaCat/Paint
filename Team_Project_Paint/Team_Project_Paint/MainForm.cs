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
        private List<IShape> _shapeList = new List<IShape>();
        private ShapePoint _lastPonit;
        private EShapeType _currentMode;
        private PaintBitmap _currentBitmap;
        private PaintBitmap _bufferedBitmap;
        private bool _isMove = false;
        private bool _isSelect = false;
        private bool _isClicked = false;

        public Paint()
        {
            InitializeComponent();

            _currentMode = EShapeType.Curve;

            IShape currentShape = ShapeFactory.CreateShape(_currentMode);
            currentShape.Thickness = _currentBrashSize;
            currentShape.Color = _curentcolor;
            _shapeList.Add(currentShape);
            

            numericUpDown1.Value = 1;

            _currentBitmap = new PaintBitmap(pictureBoxMain.Width, pictureBoxMain.Height);
            _bufferedBitmap = _currentBitmap.Clone() as PaintBitmap;
            pictureBoxMain.Image = _currentBitmap.ToImage();
        }

        private void Repaint()
        {
            if (_shapeList.Count > 0)
            {
                // Достаем последнюю фигуру, ту, которая в данный момент рисуется
                IShape currentShape = _shapeList.Last();
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
            if (!_isMove && e.Button == MouseButtons.Left)
            {
                IShape newShape = ShapeFactory.CreateShape(_currentMode);
                newShape.Color = _curentcolor;
                newShape.Thickness = _currentBrashSize;
                if (newShape is Hexagon)
                {
                    (newShape as Hexagon).Cornes = decimal.ToInt32(numericUpDown2.Value);
                    (newShape as Hexagon).Size = new ShapeSize( pictureBoxMain.Size);
                }
                _shapeList.Add(newShape);
                newShape.MouseDown(new ShapePoint(e.Location));
                Repaint();
            }
            else if (_isMove && !_isClicked && e.Button == MouseButtons.Left)
            {
                _lastPonit = new ShapePoint(e.Location);
                var select = new Select();
                select.SelectShape(_shapeList, _lastPonit);
                if (select.IsSelected)
                {
                    _isClicked = true;
                    IShape currentShape = _shapeList[select.Numb];
                    _shapeList.RemoveAt(select.Numb);
                    _currentBitmap = new PaintBitmap(pictureBoxMain.Width, pictureBoxMain.Height);
                    Repaint();
                    for (int i = 0; i < _shapeList.Count; i++)
                    {
                        if (_shapeList[i] != null)
                        {
                            _shapeList[i].Draw(PaintGraphics.FromImage(_currentBitmap));
                            Repaint();
                        }
                    }
                    currentShape.EShapeStatus = EShapeStatus.IN_PROGRESS;
                    _shapeList.Add(currentShape);
                }
            }
        }

        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (!_isClicked && !_isMove && e.Button == MouseButtons.Left)
            {
                if (_shapeList.Count > 0)
                {
                    IShape currentShape = _shapeList.Last();
                    currentShape.MouseUp(new ShapePoint(e.Location));
                    Repaint();
                }
            }
            else if (_isClicked && e.Button == MouseButtons.Left)
            {
                IShape currentShape = _shapeList.Last();
                Select move = new Select();
                move.Move(e.X - _lastPonit.X, e.Y - _lastPonit.Y, currentShape);
                currentShape.Draw(PaintGraphics.FromImage(_currentBitmap));
                if (currentShape.Name == EShapeType.Dot)
                {
                    currentShape.EShapeStatus = EShapeStatus.DONE;
                    Repaint();
                }
                
                _isClicked = false;
            }
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (_isMove && _isClicked)
                {
                    IShape currentShape = _shapeList.Last();
                    Select move = new Select();
                    move.Move(e.X - _lastPonit.X, e.Y - _lastPonit.Y, currentShape);
                    _lastPonit = new ShapePoint(e.Location);
                    Repaint();

                }
                else if (!_isMove)
                {
                    IShape currentShape = _shapeList.Last();
                    currentShape.MouseMove(new ShapePoint(e.Location));
                    Repaint();

                }
            }
        }

        private void PictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && !_isSelect && !_isMove)
            {
                if (_shapeList.Count > 0)
                {
                    IShape currentShape = _shapeList.Last();
                    currentShape.MouseClick(new ShapePoint(e.Location));
                    Repaint();
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (_shapeList.Count > 0)
                {
                    _lastPonit = new ShapePoint(e.Location);
                    var select = new Select();
                    select.SelectShape(_shapeList, _lastPonit);
                    if (select.IsSelected)
                    {
                        _shapeList.RemoveAt(select.Numb);
                        _currentBitmap = new PaintBitmap(pictureBoxMain.Width, pictureBoxMain.Height);
                        pictureBoxMain.Image = _currentBitmap.ToImage();
                    }

                    for (int i = 0; i < _shapeList.Count; i++)
                    {
                        if (_shapeList[i] != null)
                        {
                            _shapeList[i].Draw(PaintGraphics.FromImage(_currentBitmap));
                        }
                    }

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
            _shapeList.Clear();
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
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|PNG Image|*.png|JSON File|*.json";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "" && saveFileDialog1.FilterIndex == 4)
            {
                var json = new JsonLogic();
                json.JsonSerialize(_shapeList);
                File.WriteAllText(saveFileDialog1.FileName, json.File);
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
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            _currentBrashSize = (int)numericUpDown1.Value;
            trackBar1.Value = _currentBrashSize;
        }

        private void OpentoolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|PNG Image|*.png|JSON File|*.json";
            openFileDialog1.ShowDialog();

            if (openFileDialog1.FileName != "" && openFileDialog1.FilterIndex == 4)
            {
                var strings = File.ReadAllText(openFileDialog1.FileName);
                var json = new JsonLogic();
                json.JsonDeserialize(strings, _shapeList);
                _shapeList = json.JsonList;

                for (int i = 0; i < _shapeList.Count; i++)
                {
                    if (_shapeList[i] != null)
                    {
                        _shapeList[i].EShapeStatus = EShapeStatus.DONE;
                        _shapeList[i].Draw(PaintGraphics.FromImage(_currentBitmap));
                        Repaint();
                    }
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
        }

        private void NumericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (_shapeList.Count > 0)
            {
                IShape currentShape = _shapeList.Last();
                if (currentShape is Hexagon)
                {
                    (currentShape as Hexagon).Cornes = decimal.ToInt32(numericUpDown2.Value);
                }
            }
        }

        private void MoveBtn_Click(object sender, EventArgs e)
        {
            if (!_isMove)
            {
                _isMove = true;
                moveBtn.Text = "MOVE ON";
            }
            else
            {
                _isMove = false;
                moveBtn.Text = "MOVE OFF";
            }
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            if (!_isSelect)
            {
                _isSelect = true;
                selectBtn.Text = "SELECT ON";
            }
            else
            {
                _isSelect = false;
                selectBtn.Text = "SELECT OFF";
            }
        }
    }
}
