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
        readonly List<Vertex> Vertices;
        readonly List<Vertex> ShellVertices;

        public Mnogougolniki()
        {
            InitializeComponent();
            DoubleBuffered = true;
            Vertices = new List<Vertex>();
            ShellVertices = new List<Vertex>();
        }

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

        private double PolarAngle(Vertex pt1, Vertex pt2)
        {
            Point polarcords = new Point(pt2.Cords.X - pt1.Cords.X, pt2.Cords.Y - pt1.Cords.Y);
            double res = Math.Atan2(polarcords.Y, polarcords.X);
            return res >= 0 ? res : res + (2 * Math.PI);
        }

        private void CreateShell()
        {
            ShellVertices.Clear();
            int zeroptid = 0;
            for(int h = 1; h < Vertices.Count(); h++)
            {
                if (Vertices[h].Cords.X + Vertices[h].Cords.Y < Vertices[zeroptid].Cords.X + Vertices[zeroptid].Cords.Y)
                    zeroptid = h;
            }
            int id = zeroptid, nextid = -1;
            double minangle, angle;
            while
            {
                minangle = 999;
                for (int i = 0; i < Vertices.Count; i++)
                {
                    if (i == id)
                        continue;
                    angle = PolarAngle(Vertices[id], Vertices[i]);
                    if (angle < minangle)
                    {
                        nextid = i;
                        minangle = angle;
                    }
                    ShellVertices.Add(Vertices[nextid]);
                    id = nextid;
                }
            }
            Refresh();
        }   

        private void DrawShell(Graphics drawer)
        {
            Pen pen = new Pen(Color.DarkGray, 3);
            for (int i = 1; i < ShellVertices.Count; i++)
            {
                drawer.DrawLine(pen, ShellVertices[i - 1].Cords, ShellVertices[i].Cords);
            }
            drawer.DrawLine(pen, ShellVertices[0].Cords, ShellVertices[ShellVertices.Count - 1].Cords);
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

            for (int i = 0; i < Vertices.Count; i++)
            {
                Vertices[i].Delta = new Point(Vertices[i].Cords.X - e.X, Vertices[i].Cords.Y - e.Y);
                if (Vertices[i].TouchMouse(e.X, e.Y))
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        touch = true;
                        Vertices[i].BeingDragged = true;
                    }
                    else if(e.Button == MouseButtons.Right)
                    {
                        Vertices.Remove(Vertices[i]);
                        i--;
                    }
                }
            }
            if (!touch && e.Button == MouseButtons.Left)
                CreateVertex(e);
            if(Vertices.Count > 2)
                CreateShell();
            Refresh();
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (touch)
                {
                    foreach (Vertex vertex in Vertices)
                    {
                        if (vertex.BeingDragged)
                            vertex.Cords = new Point(e.X + vertex.Delta.X, e.Y + vertex.Delta.Y);
                    }
                }
                //else
                //{
                //    foreach (Vertex vertex in Vertices)
                //    {
                //        vertex.Cords = new Point(e.X + vertex.Delta.X, e.Y + vertex.Delta.Y);
                //    }
                //}
                if (Vertices.Count > 2)
                    CreateShell();
                Refresh();
            }
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            foreach(Vertex vertex in Vertices)
            {
                vertex.BeingDragged = false;
                vertex.Delta = new Point(0, 0);
            }
            touch = false;
        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach(Vertex vertex in Vertices)
            {
                vertex.Draw(e.Graphics);
            }
            if (Vertices.Count > 2)
            {
                DrawShell(e.Graphics);
            }
        }

        private void smi_ChangeColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            Vertex.Color = colorDialog1.Color;
            Refresh();
        }

        private void smi_ChangeSize_Click(object sender, EventArgs e)
        {
            FormSize formsize = new FormSize();
            formsize.ShowDialog();
            Vertex.Size = formsize.Size;
            Refresh();
        }
    }
}                                
