using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Планеты
{
    abstract class Astro
    {
        protected int size;
        protected Point cords;
        protected Astro(int size, Point cords)
        {
            this.size = size;
            this.cords = cords;
        }
        public virtual int Size
        {
            set { size = value; }
        }
        public Point Cords
        {
            set { cords = value; }
        }
        public abstract void Draw(Graphics e);
    }
    class Sun : Astro
    {
        public Sun(int size, Point cords) : base(size, cords) { this.size *= 3; }
        public override int Size
        {
            set { size = value * 3; } 
        }
        public override void Draw(Graphics drawer)
        {
            drawer.FillEllipse(new SolidBrush(Color.Yellow), cords.X, cords.Y, size, size);
        }
    }

    class Comet : Astro
    {
        public Comet(int size, Point cords) : base(size, cords) {}
        public override void Draw(Graphics drawer)
        {
            drawer.DrawLine(new Pen(Color.LightGray, size / 25), cords.X + (size / 2), cords.Y + 2, cords.X + (size * 3), cords.Y);
            drawer.DrawLine(new Pen(Color.LightGray, size / 25), cords.X + size, cords.Y + (size / 2), cords.X + (int)(size * 2.5), cords.Y + (size / 2));
            drawer.DrawLine(new Pen(Color.LightGray, size / 25), cords.X + (size / 2), cords.Y + size - 2, cords.X + (int)(size * 3.5), cords.Y + size);
            drawer.FillEllipse(new SolidBrush(Color.LightBlue), cords.X, cords.Y, size, size);
        }

    }

    class Saturn : Astro
    {
        public Saturn(int size, Point cords) : base(size, cords) { this.size *= 2; }
        public override int Size 
        { 
            set { size = value * 2; } 
        }
        public override void Draw(Graphics drawer)
        {
            drawer.FillEllipse(new SolidBrush(Color.DarkKhaki), cords.X, cords.Y, size, size);
            drawer.DrawArc(new Pen(Color.DarkOliveGreen, size / 10), cords.X - (size / 4), cords.Y + (size / 3), size / 2 * 3, size / 3, 345, 210);
        }
    }

    class Moon : Astro
    {
        public Moon(int size, Point cords) : base(size, cords) { }
        public override void Draw(Graphics drawer)
        {
            
        }

    }

}
