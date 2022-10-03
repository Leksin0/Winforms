using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пятиугольник
{

    class Pentagon
    {
        int distMultiplier;
        Color color;
        Point center;
        Point[] vertexes;
        static readonly int distBase = 20;
        static readonly float[,] distModifiers = { { 0f, -1f }, { 0.951f, -0.309f }, { 0.587f, 0.809f }, { -0.587f, 0.809f }, { -0.951f, -0.309f } };
        static readonly Random generator = new Random();
        static readonly Color[] colorsArray = {Color.DarkOrange, Color.Magenta, Color.LimeGreen, Color.Crimson, Color.DarkCyan};
        public Pentagon(Point center)
        {
            vertexes = new Point[5];
            this.center = center;
            distMultiplier = 0;
        }
        public void Redraw()
        {
            color = colorsArray[generator.Next(5)];
            distMultiplier = generator.Next(4, 10);
            for (int i = 0; i < 5; i++)
            {
                vertexes[i] = new Point(center.X + (int)Math.Round(distBase * distMultiplier * distModifiers[i,0]), center.Y + (int)Math.Round(distBase * distMultiplier * distModifiers[i, 1]));
            }
        }
        public Point[] Vertexes
        {
            get
            {
                return vertexes;
            }
        }
        public Color FillColor
        {
            get
            {
                return color;
            }
        }
    }
}