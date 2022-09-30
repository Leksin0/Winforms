using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace кружочьек
{

    public partial class Form1 : Form
    {
        static readonly string[] sizeArray = { "Большой", "Средний", "Маленький" };
        static readonly string[] shapeArray = { "Прямоугольник", "Треугольник", "Эллипс", "Круг", "Квадрат" };
        static readonly string[] colorArray = { "Зелёный", "Синий", "Оранжевый", "Фиолетовый", "Бирюзовый" };
        Color figureColor;
        public Form1()
        {
            InitializeComponent();
            cmbxSize.DataSource = sizeArray;
            cmbxShape.DataSource = shapeArray;
            cmbxColor.DataSource = colorArray;
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            switch (cmbxColor.Text)
            {
                case "Зелёный":
                    figureColor = Color.Green;
                    break;
                case "Синий":
                    figureColor = Color.Blue;
                    break;
                case "Оранжевый":
                    figureColor = Color.Orange;
                    break;
                case "Фиолетовый":
                    figureColor = Color.Magenta;
                    break;
                case "Бирюзовый":
                    figureColor = Color.Cyan;
                    break;
            }
            panCanvas.Refresh();
        }

        private void panCanvas_Paint(object sender, PaintEventArgs e)
        {
            Point center = new Point(panCanvas.Width / 2, panCanvas.Height / 2);
            Point LT;
            Size SZ;
            Graphics drawer = e.Graphics;
            if (cmbxSize.Text == "Большой")
            { 
                LT = new Point(panCanvas.Width / 8, panCanvas.Height / 8);
                SZ = new Size(panCanvas.Width / 4 * 3, panCanvas.Height / 4 * 3);
                switch (cmbxShape.Text)
                {
                    case "Прямоугольник":
                        drawer.FillRectangle(new SolidBrush(figureColor), LT.X, LT.Y, SZ.Width, SZ.Height);
                        break;
                    case "Квадрат":
                        drawer.FillRectangle(new SolidBrush(figureColor), LT.X, LT.Y, SZ.Height, SZ.Height);
                        break;
                    case "Треугольник":
                        // треугольника пока нeт
                        break;
                    case "Эллипс":
                        drawer.FillEllipse(new SolidBrush(figureColor), LT.X, LT.Y, SZ.Width, SZ.Height);
                        break;
                    case "Круг":
                        drawer.FillEllipse(new SolidBrush(figureColor), LT.X, LT.Y, SZ.Height, SZ.Height);
                        break;
                }
            }
            else if (cmbxSize.Text == "Средний")
            {
                LT = new Point(panCanvas.Width / 2, panCanvas.Height / 2);
                SZ = new Size(panCanvas.Width / 2, panCanvas.Height / 2);

            }
            else
            {
                LT = new Point(panCanvas.Width / 4, panCanvas.Height / 4);
                SZ = new Size(panCanvas.Width / 4, panCanvas.Height / 4);
                switch (cmbxShape.Text)
                {

                }
            }
        }
    }
}
