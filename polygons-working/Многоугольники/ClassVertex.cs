using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Многоугольники
{
    abstract class Vertex
    {
        protected int R = 36;
        protected Brush brush = new SolidBrush(Color.DarkBlue);
        protected Point cords;
        private Point delta;
        protected bool dragging;

        public Vertex(Point cords)
        {
            this.cords = cords;
        }

        public Point Cords
        {
            get { return cords; }
            set { cords = new Point(value.X, value.Y); }
        }
        public Point Delta
        {
            get { return delta; }
            set { delta = value; }
        }

        public bool Dragging
        {
            get { return dragging; }
            set { dragging = value; }
        }

        public abstract void Draw(Graphics drawer);
        public abstract bool TouchMouse(int x, int y);
    }

    class Circle : Vertex
    {
        public Circle(Point cords) : base(cords) { }
        public override void Draw(Graphics drawer)
        {
            drawer.FillEllipse(brush, cords.X - (R / 2), cords.Y - (R / 2), R, R);
        }
        public override bool TouchMouse(int x, int y)
        {
            return Math.Sqrt(Math.Pow(Math.Abs(x - cords.X), 2) + Math.Pow(Math.Abs(y - cords.Y), 2)) < R / 2;
        }
    }

    class Square : Vertex
    {
        public Square(Point cords) : base(cords) { }
        public override void Draw(Graphics drawer)
        {
            drawer.FillRectangle(brush, cords.X - (R / 2), cords.Y - (R / 2), R, R);
        }
        public override bool TouchMouse(int x, int y)
        {
            return x > cords.X - (R / 2) && x < cords.X + (R / 2) && y > cords.Y - (R / 2) && y < cords.Y + (R / 2);
        }
    }

    class Triangle : Vertex
    {
        public Triangle(Point cords) : base(cords) { }
        public override void Draw(Graphics drawer)
        {
            Point[] subps = {
                new Point(cords.X, cords.Y - (int)(R / 1.5)),
                new Point(cords.X - (int)(R * Math.Sqrt(3) / 3), cords.Y + (R / 3)),
                new Point(cords.X + (int)(R * Math.Sqrt(3) / 3), cords.Y + (R / 3)) };
            drawer.FillPolygon(brush, subps);
        }
        public override bool TouchMouse(int x, int y)
        {
            return y - Cords.Y + (R / 1.5) > Math.Tan(120 * Math.PI / 180) * (x - cords.X) &&
                y - Cords.Y + (R / 1.5) > Math.Tan(60 * Math.PI / 180) * (x - cords.X) && y < Cords.Y + (R / 3);
        }
    }
}
