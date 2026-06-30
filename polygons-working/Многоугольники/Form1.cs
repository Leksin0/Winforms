using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Многоугольники
{
    enum Shape
    {
        Circle,
        Square,
        Triangle
    }

    public partial class Mnogougolniki : Form
    {
        Shape shape;
        bool touch;
        List<Vertex> Vertices;

        public Mnogougolniki()
        {
            InitializeComponent();
            DoubleBuffered = true;
            Vertices = new List<Vertex>();
        }

        #region Выбор формы
        private void smi_Circle_Click(object sender, EventArgs e)
        {
            shape = Shape.Circle;
        }

        private void smi_Square_Click(object sender, EventArgs e)
        {
            shape = Shape.Square;
        }

        private void smi_Triangle_Click(object sender, EventArgs e)
        {
            shape = Shape.Triangle;
        }
        #endregion

        private void CreateVertex(MouseEventArgs e)
        {
            switch (shape)
            {
                case Shape.Circle:
                    Vertices.Add(new Circle(new Point(e.X, e.Y)));
                    break;
                case Shape.Square:
                    Vertices.Add(new Square(new Point(e.X, e.Y)));
                    break;
                case Shape.Triangle:
                    Vertices.Add(new Triangle(new Point(e.X, e.Y)));
                    break;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if(Vertices.Count == 0)
            {
                if (e.Button == MouseButtons.Left)
                {
                    CreateVertex(e);
                }
                Refresh();
                return;
            }
            flag:
            foreach (Vertex vertex in Vertices)
            {
                if(vertex.TouchMouse(e.X, e.Y))
                {
                    if(e.Button == MouseButtons.Left)
                    {
                        touch = true;
                        vertex.Dragging = true;
                        vertex.Delta = new Point(vertex.Cords.X - e.X, vertex.Cords.Y - e.Y);
                    }
                    else if(e.Button == MouseButtons.Right)
                    {
                        Vertices.Remove(vertex);
                        goto flag;
                    }
                }
            }
            if(!touch)
            {
                if (e.Button == MouseButtons.Left)
                {
                    CreateVertex(e);
                }
            }
            Refresh();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(touch)
            {
                foreach(Vertex vertex in Vertices)
                {
                    if(vertex.Dragging)
                        vertex.Cords = new Point(e.X + vertex.Delta.X, e.Y + vertex.Delta.Y);
                }
                Refresh();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            touch = false;
            foreach(Vertex vertex in Vertices)
            {
                vertex.Delta = new Point(0, 0);
                vertex.Dragging = false;
            }
            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach(Vertex vertex in Vertices)
            {
                vertex.Draw(e.Graphics);
            }
        }
    }
}
