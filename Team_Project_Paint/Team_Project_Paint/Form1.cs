using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Team_Project_Paint.Class;
using Team_Project_Paint.Interfaces;

namespace Team_Project_Paint
{
    public partial class Paint : Form
    {
        private Color _currentColor = Color.Black;
        private int _currentBrashSize = 3;
        private List<Shape> shapeList = new List<Shape>();
        private Bitmap _currentBitmap;


        public Paint()
        {
            InitializeComponent();
            _currentBitmap = new Bitmap(800, 600);
            Shape currentShape = new Curve();
            currentShape.Thickness = _currentBrashSize;
            currentShape.Color = _currentColor;
            shapeList.Add(currentShape);
            numericUpDown1.Value = 3;
        }

        private void rePaint()
        {
            Graphics graphics = Graphics.FromImage(_currentBitmap);
            graphics.Clear(Color.White);
            foreach (Shape shape in shapeList)
            {
                shape.Draw(graphics);
            }
            Shape lastShape = shapeList.Last();
            if (lastShape.IsFinished())
            {
                Shape newShape = ShapeFactory.CreateShape(lastShape.Name);
                newShape.Color = _currentColor;
                newShape.Thickness = _currentBrashSize;
                shapeList.Add(newShape);
            }
            pictureBoxMain.Image = _currentBitmap;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Shape currentShape = shapeList.Last();
            currentShape.MouseDown(sender, e);
            rePaint();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            Shape currentShape = shapeList.Last();
            currentShape.MouseUp(sender, e);
            rePaint();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Shape currentShape = shapeList.Last();
            currentShape.MouseMove(sender, e);
            rePaint();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Shape currentShape = shapeList.Last();
            currentShape.MouseClick(sender, e);
            rePaint();
        }

        private void DotButton_Click(object sender, EventArgs e)
        {

            Shape shape = new Dot();
            shape.Color = _currentColor;
            shape.Thickness = _currentBrashSize;
            shapeList.Add(shape);
        }

        private void LineButton_Click(object sender, EventArgs e)
        {
            Shape shape = new Line();
            shape.Color = _currentColor;
            shape.Thickness = _currentBrashSize;
            shapeList.Add(shape);
        }

        private void CurveButton_Click(object sender, EventArgs e)
        {
            Shape shape = new Curve();
            shape.Color = _currentColor;
            shape.Thickness = _currentBrashSize;
            shapeList.Add(shape);
        }

        private void RectangleButton_Click(object sender, EventArgs e)
        {
            Shape shape = new Rect();
            shape.Color = _currentColor;
            shape.Thickness = _currentBrashSize;
            shapeList.Add(shape);
        }

        private void EllipseButton_Click(object sender, EventArgs e)
        {
            Shape shape = new Ellipse();
            shape.Color = _currentColor;
            shape.Thickness = _currentBrashSize;
            shapeList.Add(shape);
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            shapeList.Clear();
            Shape currentShape = new Curve();
            currentShape.Thickness = _currentBrashSize;
            currentShape.Color = _currentColor;
            shapeList.Add(currentShape);
            rePaint();
        }


        private void button7_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                button5.BackColor = colorDialog1.Color;
                _currentColor = colorDialog1.Color;
                Shape currentShape = shapeList.Last();
                currentShape.Color = _currentColor;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            button5.BackColor = b.BackColor;
            _currentColor = button5.BackColor;
            Shape currentShape = shapeList.Last();
            currentShape.Color = _currentColor;
        }


        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                _currentBitmap.Save(saveFileDialog1.FileName);
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            _currentBrashSize = trackBar1.Value;
            numericUpDown1.Value = _currentBrashSize;
            Shape currentShape = shapeList.Last();
            currentShape.Thickness = _currentBrashSize;
        }
    }
}
