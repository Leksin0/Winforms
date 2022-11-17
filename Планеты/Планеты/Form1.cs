using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Планеты
{
    public partial class Form1 : Form
    {
        static bool[] visible = new bool[4];
        static Astro[] astros = new Astro[4];
        public Form1()
        {
            InitializeComponent();
            int size = (Space.Height < Space.Width ? Space.Height : Space.Width) / 8;
            astros[0] = new Sun(size, new Point(Space.Width / 6, Space.Height / 5));
            astros[1] = new Moon(size, new Point(Space.Width / 4, Space.Height / 5 * 4));
            astros[2] = new Comet(size, new Point(Space.Width / 5 * 3, Space.Height / 6));
            astros[3] = new Saturn(size, new Point(Space.Width / 3 * 2, Space.Height / 5 * 3));
        }

        private void Space_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < 4; i++)
                if (visible[i])
                    astros[i].Draw(e.Graphics);
        }

        private void Space_SizeChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
                astros[i].Size = (Space.Height < Space.Width ? Space.Height : Space.Width) / 8;
            astros[0].Cords = new Point(Space.Width / 6, Space.Height / 5);
            astros[1].Cords = new Point(Space.Width / 4, Space.Height / 5 * 4);
            astros[2].Cords = new Point(Space.Width / 5 * 3, Space.Height / 6);
            astros[3].Cords = new Point(Space.Width / 3 * 2, Space.Height / 5 * 3);
            Space.Refresh();
        }

        private void chbSun_CheckedChanged(object sender, EventArgs e)
        {
            if (chbSun.Checked)
                visible[0] = true;
            else
                visible[0] = false;
            Space.Refresh();
        }

        private void chbMoon_CheckedChanged(object sender, EventArgs e)
        {
            if (chbMoon.Checked)
                visible[1] = true;
            else
                visible[1] = false;
            Space.Refresh();
        }

        private void chbComet_CheckedChanged(object sender, EventArgs e)
        {
            if (chbComet.Checked)
                visible[2] = true;
            else
                visible[2] = false;
            Space.Refresh();
        }

        private void chbSaturn_CheckedChanged(object sender, EventArgs e)
        {
            if (chbSaturn.Checked)
                visible[3] = true;
            else
                visible[3] = false;
            Space.Refresh();
        }
    }
}
