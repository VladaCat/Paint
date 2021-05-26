using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using Team_Project_Paint.Class;
using Team_Project_Paint.Enum;
using Team_Project_Paint.Interfaces;

namespace Team_Project_Paint
{
    public partial class Paint : Form
    {
        private Color _currentColor = Color.Black;
        private int _currentBrashSize = 1;
        private List<IShape> _shapeList = new List<IShape>();
        private Bitmap _currentBitmap;
        private IShape _currentShape;
        private EShapeType _currentMode;
        private Bitmap _tempBitmap;
        private Graphics _graphics;
        private Point _lastPonit;
        private Select _move;
        private bool _isClicked = false;
        private bool _isMove = false;

        public Paint()
        {
            InitializeComponent();
            _currentMode = EShapeType.Curve;
            _currentBitmap = new Bitmap(pictureBoxMain.Width,pictureBoxMain.Height);
            IShape currentShape = new Curve();
            currentShape.Thickness = _currentBrashSize;
            currentShape.Color = _currentColor;
            _shapeList.Add(currentShape);
            numericUpDown1.Value = 1;
            pictureBoxMain.Image = _currentBitmap;
            _tempBitmap = new Bitmap(_currentBitmap);
            _graphics = Graphics.FromImage(_tempBitmap);
        }

        private void RePaint()
        {   
            _tempBitmap = new Bitmap(_currentBitmap);
            _graphics = Graphics.FromImage(_tempBitmap);
            pictureBoxMain.Image = _currentBitmap;
        }

        private void RePaintTemp() 
        {
            if (_currentMode == EShapeType.Curve)
            {

            }
            else 
            {
                _graphics.Clear(Color.White);
                _graphics.DrawImage(_currentBitmap,0,0);
            }
            _currentShape.DrawTemp(_graphics);
            pictureBoxMain.Image = _tempBitmap;
        } 

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _currentShape = ShapeFactory.CreateShape(_currentMode);
                _currentShape.Color = _currentColor;
                _currentShape.Thickness = _currentBrashSize;
                if (_currentShape is Hexagon)
                {
                    (_currentShape as Hexagon).Cornes = decimal.ToInt32(numericUpDown2.Value);
                    (_currentShape as Hexagon).Size = pictureBoxMain.Size;
                }
                _shapeList.Add(_currentShape);
                _currentShape.MouseDown(sender, e);
            }
            else if (_isMove && e.Button == MouseButtons.Right)
            {
                _lastPonit = e.Location;
                _currentMode = EShapeType.Select;
                var select = ShapeFactory.CreateShape(_currentMode);
                select.SelectShape(_shapeList, e);
                if (select.isClicked)
                {
                    _isClicked = true;
                    _currentShape = _shapeList[select.Numb];
                    _shapeList.RemoveAt(select.Numb);
                    _currentBitmap = new Bitmap(pictureBoxMain.Width, pictureBoxMain.Height);
                    RePaint();
                    for (int i = 0; i < _shapeList.Count; i++)
                    {
                        if (_shapeList[i] != null)
                        {
                            _shapeList[i].Draw(Graphics.FromImage(_currentBitmap));
                            RePaint();
                        }
                    }
                }

            }
            // перемещение 
        }

        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (_currentShape != null && e.Button == MouseButtons.Left)
            {
                _currentShape.MouseUp(sender, e);
                _currentShape.Draw(Graphics.FromImage(_currentBitmap));
                RePaint();
            }
            else if (_isClicked && e.Button == MouseButtons.Right)
            {
                _move = new Select();
                _move.Move(e.X - _lastPonit.X, e.Y - _lastPonit.Y, _currentShape);
                _shapeList.Add(_currentShape);
                _currentShape.Draw(Graphics.FromImage(_currentBitmap));
                RePaint();
                _isClicked = false;
            }
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_currentShape != null && e.Button == MouseButtons.Left) 
            { 
                _currentShape.MouseMove(sender, e);
                RePaintTemp();
            }
            else if (_isClicked && _currentShape != null && e.Button == MouseButtons.Right)
            {
                _move = new Select();
                _move.Move(e.X - _lastPonit.X, e.Y - _lastPonit.Y, _currentShape);
                _lastPonit = e.Location;
                RePaintTemp();
            }
        }

        private void PictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (_currentShape != null && e.Button == MouseButtons.Left)
            {
                _currentShape = _shapeList.Last();
                _currentShape.MouseClick(sender, e);
                RePaint();
            }
            else if (!_isMove && e.Button == MouseButtons.Right)
            {
                _currentMode = EShapeType.Select;

                if (_shapeList.Count > 0)
                {
                    _currentShape = null;
                    var select = ShapeFactory.CreateShape(_currentMode);
                    select.SelectShape(_shapeList, e);
                    if (select.isClicked)
                    {
                        _shapeList.RemoveAt(select.Numb);
                        _currentBitmap = new Bitmap(pictureBoxMain.Width, pictureBoxMain.Height);
                        RePaint();
                        for (int i = 0; i < _shapeList.Count; i++)
                        {
                            if (_shapeList[i] != null)
                            {
                                _shapeList[i].Draw(Graphics.FromImage(_currentBitmap));
                                RePaint();
                            }
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
            _currentBitmap = new Bitmap(pictureBoxMain.Width, pictureBoxMain.Height);
            _currentShape = null;
            RePaint();
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            CurrentColorButton.BackColor = b.BackColor;
            _currentColor = CurrentColorButton.BackColor;
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|PNG Image|*.png";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
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
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                _currentBitmap = (Bitmap)Bitmap.FromFile(openFileDialog1.FileName);
            }
            RePaint();
        }

        private void ChengeColorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                CurrentColorButton.BackColor = colorDialog1.Color;
                _currentColor = colorDialog1.Color;
            }
        }

        private void NumericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (_currentShape is Hexagon)
            {
                (_currentShape as Hexagon).Cornes = decimal.ToInt32(numericUpDown2.Value);
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
    }
}
