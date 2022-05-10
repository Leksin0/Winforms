using System;

namespace Фоновая_6_2
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
        public abstract void Show();
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
        public override void Show()
        {
            Console.WriteLine($"Катеты: {a}, {b}, гипотенуза {SideC}");
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
        public override void Show()
        {
            Console.WriteLine($"Все стороны равны {a}, все углы 60°");
        }
    }


    class MainClass
    {
        public static void Main()
        {
            Console.WriteLine("Введите два любых числа");
            int a = 1, b = 1; bool isnum = true; Triangle[] tris = new Triangle[2];
            while (isnum)
            {
                try
                {
                    Console.Write("Первое  "); a = int.Parse(Console.ReadLine());
                    Console.Write("И второе  "); b = int.Parse(Console.ReadLine());
                    isnum = false;
                }
                catch
                {
                    Console.WriteLine("Введите число!");
                }
            }
            Console.Clear();
            tris[0] = new RectangularTriangle(a, b);
            tris[1] = new EquilateralTriangle(a);
            foreach (Triangle tringl in tris)
            {
                tringl.Show();
                Console.WriteLine($"Периметр: {tringl.Perimetr}");
                Console.WriteLine($"Площадь: {tringl.Area}");
                Console.WriteLine(tringl.IsSpecial ? "Равнобедренный" : "Неравнобедренный");
                Console.WriteLine();
            }
        }
    }
}
