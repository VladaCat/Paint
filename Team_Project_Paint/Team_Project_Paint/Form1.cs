using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using Team_Project_Paint.Class;
using Team_Project_Paint.Interfaces;

namespace Team_Project_Paint
{
    public partial class Paint : Form
    {
        private Color _currentColor = Color.Black;
        private int _currentBrashSize = 1;
        private List<IShape> shapeList = new List<IShape>();
        private Bitmap _currentBitmap;
        private IShape currentShape;
        private string currentMode;
        Bitmap tempBitmap;
        Graphics graphics;

        public Paint()
        {
            InitializeComponent();
            currentMode = "Curve";
            _currentBitmap = new Bitmap(800, 600);
            IShape currentShape = new Curve();
            currentShape.Thickness = _currentBrashSize;
            currentShape.Color = _currentColor;
            shapeList.Add(currentShape);
            numericUpDown1.Value = 1;
            pictureBoxMain.Image = _currentBitmap;
            tempBitmap = new Bitmap(_currentBitmap);
            graphics = Graphics.FromImage(tempBitmap);
        }

        private void rePaint()
        {
            //Graphics graphics = Graphics.FromImage(_currentBitmap);
            //graphics.Clear(Color.White);
            //foreach (IShape shape in shapeList)
            //{
            //    shape.Draw(graphics);
            //}
            //IShape lastShape = shapeList.Last();
            //if (lastShape.IsFinished())
            //{
            //    IShape newShape = ShapeFactory.CreateShape(lastShape.Name);
            //    newShape.Color = _currentColor;
            //    newShape.Thickness = _currentBrashSize;
            //    shapeList.Add(newShape);
            //}
            
            tempBitmap = new Bitmap(_currentBitmap);
            graphics = Graphics.FromImage(tempBitmap);
            pictureBoxMain.Image = _currentBitmap;
        }

        private void rePaintTemp() 
        {
            if (currentMode == "Curve")
            {

            }
            else 
            {
                graphics.Clear(Color.White);
                graphics.DrawImage(_currentBitmap,0,0);
            }
            currentShape.DrawTemp(graphics);
            pictureBoxMain.Image = tempBitmap;
        } 

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
                currentShape = ShapeFactory.CreateShape(currentMode);
                currentShape.Color = _currentColor;
                currentShape.Thickness = _currentBrashSize;
                shapeList.Add(currentShape);
                currentShape.MouseDown(sender, e);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (currentShape != null)
            {
                currentShape.MouseUp(sender, e);
                currentShape.Draw(Graphics.FromImage(_currentBitmap));
                rePaint();
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (currentShape != null) 
            { 
                currentShape.MouseMove(sender, e);
                rePaintTemp();
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (currentShape != null)
            {
                currentShape = shapeList.Last();
                currentShape.MouseClick(sender, e);
                rePaint();
            }
        }

        private void DotButton_Click(object sender, EventArgs e)
        {
            currentMode = "Dot";
            //IShape shape = new Dot();
            //shape.Color = _currentColor;
            //shape.Thickness = _currentBrashSize;
            //shapeList.Add(shape);
        }

        private void LineButton_Click(object sender, EventArgs e)
        {
            currentMode = "Line";
            //IShape shape = new Line();
            //shape.Color = _currentColor;
            //shape.Thickness = _currentBrashSize;
            //shapeList.Add(shape);
        }

        private void CurveButton_Click(object sender, EventArgs e)
        {
            currentMode = "Curve";
            //IShape shape = new Curve();
            //shape.Color = _currentColor;
            //shape.Thickness = _currentBrashSize;
            //shapeList.Add(shape);
        }

        private void RectangleButton_Click(object sender, EventArgs e)
        {
            currentMode = "Rect";
            //IShape shape = new Rect();
            //shape.Color = _currentColor;
            //shape.Thickness = _currentBrashSize;
            //shapeList.Add(shape);
        }

        private void EllipseButton_Click(object sender, EventArgs e)
        {
            currentMode = "Ellipse";
            //IShape shape = new Ellipse();
            //shape.Color = _currentColor;
            //shape.Thickness = _currentBrashSize;
            //shapeList.Add(shape);
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            shapeList.Clear();
            _currentBitmap = new Bitmap(800, 600);
            currentShape = null;
            //IShape currentShape = new Curve();
            //currentShape.Thickness = _currentBrashSize;
            //currentShape.Color = _currentColor;
            //shapeList.Add(currentShape);
            rePaint();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                button5.BackColor = colorDialog1.Color;
                _currentColor = colorDialog1.Color;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            button5.BackColor = b.BackColor;
            _currentColor = button5.BackColor;
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
        }

        //прикол чтобы не рисовать 0й кистью прописали в свойствах на форме минимум и максимум у numericUpDown
        private void numericUpDown1_ValueChanged(object sender, EventArgs e) // отображение для трекбара 
        {
            _currentBrashSize = (int)numericUpDown1.Value;
            trackBar1.Value = _currentBrashSize;
        }

        //можно открывать и рисовать в существующих файлах
        private void opentoolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                _currentBitmap = (Bitmap)Bitmap.FromFile(openFileDialog1.FileName);
            }
            rePaint();
        }
    }
}
