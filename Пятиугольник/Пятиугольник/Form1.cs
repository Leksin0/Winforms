using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Пятиугольник
{
    public partial class Form1 : Form
    {
        Pentagon figure;
        public Form1()
        {
            InitializeComponent();
            figure = new Pentagon(new Point(panCanvas.Width/2, panCanvas.Height / 2));
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            figure.Redraw();
            panCanvas.Refresh();
        }

        private void panCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics drawer = e.Graphics;
            drawer.FillPolygon(new SolidBrush(figure.FillColor), figure.Vertexes);
        }
    }
}
