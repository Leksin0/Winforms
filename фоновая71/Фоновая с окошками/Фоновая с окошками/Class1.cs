using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Фоновая_с_окошками
{
    static class DegRad
    {
        public static double ConvertToRad(double a)
        {
            return a * 180 / Math.PI;
        }
        public static double ConvertToDeg(double a)
        {
            return a * Math.PI / 180;
        }
    }
    abstract class Triangle
    {
        protected string name;
        protected int a;
        protected int b;
        protected Triangle()
        {
            a = 10;
            b = 8;
        }
        protected Triangle(int a, int b, double alfa)
        {
            this.a = a;
            this.b = b;
        }
        public abstract int SideA { get; set; }
        public abstract int SideB { get; set; }
        public abstract double SideC { get; }
        public abstract double Area { get; }
        public abstract bool IsSpecial { get; }
        public abstract string message { get; }
        public double Perimetr
        {
            get
            {
                return SideA + SideB + SideC;
            }
        }
        public double MidLine
        {
            get
            {
                return SideC / 2;
            }
        }
    }
    class RectangularTriangle : Triangle
    {
        public RectangularTriangle() : base(10, 8, 90) { }
        public RectangularTriangle(int a, int b) : base(a, b, 90) { }
        public override int SideA
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
            }
        }
        public override int SideB
        {
            get
            {
                return b;
            }
            set
            {
                b = value;
            }
        }
        public override double SideC
        {
            get
            {
                return Math.Sqrt(((double)a * a) + ((double)b * b));
            }
        }
        public override double Area
        {
            get
            {
                return a * b / 2;
            }
        }
        public override bool IsSpecial
        {
            get
            {
                return a == b;
            }
        }
        public override string message
        {
            get
            {
                return$"Катеты: {a}, {b}, гипотенуза {SideC}";
            }
        }
    }
    class EquilateralTriangle : Triangle
    {
        public EquilateralTriangle() : base(10, 10, 60) { }
        public EquilateralTriangle(int a) : base(a, a, 60) { }
        public override int SideA
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
                b = value;
            }
        }
        public override int SideB
        {
            get
            {
                return b;
            }
            set
            {
                a = value;
                b = value;
            }
        }
        public override double SideC
        {
            get
            {
                return a;
            }
        }
        public override double Area
        {
            get
            {
                return a * a / 2 * Math.Sin(DegRad.ConvertToRad(60));
            }
        }
        public override bool IsSpecial
        {
            get
            {
                return true;
            }
        }
        public override string message
        {
            get
            {
                return $"Все стороны равны {a}, все углы 60°";
            }
        }
    }
}
