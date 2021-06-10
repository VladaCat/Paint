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
    public partial class MainForm : Form
    {
        private PaintColor _curentcolor = new PaintColor(0, 0, 0);
        private BusinessLogic _bl;
        private ShapePoint _lastPonit;
        private EShapeType _currentMode;
        private PaintBitmap _currentBitmap;
        private PaintBitmap _bufferedBitmap;
        private bool _isMoveMode = false;
        private bool _isSelectMode = false;
        private bool _isStartMove = false;
        private bool _isSelected = false;
        private int _cornesValue = 3;
        private int _currentBrashSize = 1;
        private const string TEXT_FOR_SELECT_ON = "SELECT ON";
        private const string TEXT_FOR_SELECT_OFF = "SELECT OFF";
        private const string TEXT_FOR_MOVE_ON = "MOVE ON";
        private const string TEXT_FOR_MOVE_OFF = "MOVE OFF";


        public MainForm()
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
            if (_bl.isBoolCount())
            {
                IShape currentShape = _bl.Last();
                _bufferedBitmap = _currentBitmap.Clone() as PaintBitmap;
                PaintGraphics _bufferedGraphics = PaintGraphics.FromImage(_bufferedBitmap);
                currentShape.Draw(_bufferedGraphics);
                if (currentShape.EShapeStatus == EShapeStatus.IN_PROGRESS)
                {
                    pictureBoxMain.Image = _bufferedBitmap?.ToImage();
                }
                if (currentShape.EShapeStatus == EShapeStatus.DONE)
                {
                    _currentBitmap = _bufferedBitmap?.Clone() as PaintBitmap;
                    pictureBoxMain.Image = _currentBitmap?.ToImage();
                }
            }
        }

        private void MainPictureBox_MouseDown(object sender, MouseEventArgs e)
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
                _isSelected = _bl.IsSelectShape(_lastPonit);

                if (_isSelected && _isMoveMode)
                {
                    _isStartMove = true;
                    IShape currentShape = _bl.GetSelectedShape();
                    _currentBitmap = new PaintBitmap(pictureBoxMain.Width, pictureBoxMain.Height);
                    Repaint();
                    _bl.UpdatePicture(_currentBitmap);
                    currentShape.EShapeStatus = EShapeStatus.IN_PROGRESS;
                    _bl.AddSelectShape(currentShape);
                    Repaint();
                }
            }
        }


        private void MainPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (!_isStartMove && !_isSelectMode && !_isMoveMode && e.Button == MouseButtons.Left)
            {
                if (_bl.isBoolCount())
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

        private void MainPictureBox_MouseMove(object sender, MouseEventArgs e)
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
                else if (!_isMoveMode && !_isSelectMode && _bl.isBoolCount())
                {
                    IShape currentShape = _bl.Last();
                    currentShape.MouseMove(new ShapePoint(e.Location));
                    Repaint();

                }
            }
        }

        private void MainPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && !_isSelectMode && !_isMoveMode)
            {
                if (_bl.isBoolCount())
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
        private void HexagonButton_Click(object sender, EventArgs e)
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

            if (_bl.isBoolCount() && _isSelected)
            {
                _currentBitmap = new PaintBitmap(pictureBoxMain.Width, pictureBoxMain.Height);
                pictureBoxMain.Image = _currentBitmap.ToImage();
                _bl.ChangeFigureColor(_currentBitmap, _curentcolor);
            }


        }

        private void SaveFileButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|PNG Image|*.png|JSON File|*.json";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "" && saveFileDialog1.FilterIndex == 4 && saveFileDialog1.FileName != "saveFileDialog1")
            {
                _bl.JsonSave(saveFileDialog1.FileName);
            }
            else if (saveFileDialog1.FileName != "" && saveFileDialog1.FileName != "saveFileDialog1")
            {
                _currentBitmap.Save(saveFileDialog1.FileName);
            }
        }

        private void BrushSizeTrackBar_Scroll(object sender, EventArgs e)
        {
            _currentBrashSize = trackBar1.Value;
            if (_bl.isBoolCount() && _isSelected)
            {
                _currentBitmap = new PaintBitmap(pictureBoxMain.Width, pictureBoxMain.Height);
                pictureBoxMain.Image = _currentBitmap.ToImage();
                _bl.ChanhgeFirgureThickness(_currentBitmap, _currentBrashSize);
            }
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|PNG Image|*.png|JSON File|*.json";
            openFileDialog1.ShowDialog();

            if (openFileDialog1.FileName != "" && openFileDialog1.FileName != "openFileDialog1")
            {
                _bl.Clear();
                _currentBitmap = new PaintBitmap(pictureBoxMain.Width, pictureBoxMain.Height);
                _bufferedBitmap = _currentBitmap.Clone() as PaintBitmap;
                pictureBoxMain.Image = _currentBitmap.ToImage();
                Repaint();

                if (openFileDialog1.FilterIndex == 4)
                {
                    var strings = File.ReadAllText(openFileDialog1.FileName);

                    if (_bl.JsonOpen(strings, _currentBitmap))
                    {
                        Repaint();
                    }
                }
                else
                {
                    _currentBitmap = (PaintBitmap)PaintImage.FromFile(openFileDialog1.FileName);
                    pictureBoxMain.Image = _currentBitmap.ToImage();
                    Repaint();
                }
            }
        }

        private void ChangeColorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                CurrentColorButton.BackColor = colorDialog1.Color;
                _curentcolor = new PaintColor(colorDialog1.Color);
            }

            if (_bl.isBoolCount() && _isSelected)
            {
                _currentBitmap = new PaintBitmap(pictureBoxMain.Width, pictureBoxMain.Height);
                pictureBoxMain.Image = _currentBitmap.ToImage();
                _bl.ChangeFigureColor(_currentBitmap, _curentcolor);
            }
        }

        private void CornesNumeric_ValueChanged(object sender, EventArgs e)
        {
            _cornesValue = decimal.ToInt32(numericUpDown2.Value);
            if (_bl.isBoolCount())
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
                moveBtn.Text = TEXT_FOR_MOVE_ON;
                deleteBtn.Enabled = false;
            }
            else
            {
                _isMoveMode = false;
                moveBtn.Text = TEXT_FOR_MOVE_OFF;
                deleteBtn.Enabled = true;
            }
        }

        private void SelectBtn_Click(object sender, EventArgs e)
        {
            if (!_isSelectMode)
            {
                _isSelectMode = true;
                selectBtn.Text = TEXT_FOR_SELECT_ON;
                moveBtn.Enabled = true;
                deleteBtn.Enabled = true;
            }
            else
            {
                _isSelectMode = false;
                _isSelected = false;
                _isMoveMode = false;
                moveBtn.Text = TEXT_FOR_MOVE_OFF;
                selectBtn.Text = TEXT_FOR_SELECT_OFF;
                moveBtn.Enabled = false;
                deleteBtn.Enabled = false;
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (_bl.isBoolCount() && _isSelected)
            {
                _currentBitmap = new PaintBitmap(pictureBoxMain.Width, pictureBoxMain.Height);
                pictureBoxMain.Image = _currentBitmap.ToImage();
                _bl.Delete(_currentBitmap);
                _isSelected = false;
            }
        }

        private void statsBtn_Click(object sender, EventArgs e)
        {
            Form stats = new StatsForm();
            stats.Show();
            this.Hide();
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            Form login = new AutorizationForm();
            login.Show();
            this.Hide();
        }
    }
}
