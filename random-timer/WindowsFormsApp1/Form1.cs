using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int x, y, sx, sy, speed;
        double d;
        Random randomiser;

        private void changeSpeed_Click(object sender, EventArgs e)
        {
            Form2 speedForm = new Form2();
            speedForm.ShowDialog();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DoubleBuffered = true;
            randomiser = new Random();
            mainTimer.Interval = 10;
            speed = 1;
            sx = 1;
            sy = 1;
            x = 30;
            y = 30;
        }

        private void switchTimer_Click(object sender, EventArgs e)
        {
            if(mainTimer.Enabled)
            {
                switchTimer.Text = "Go";
                mainTimer.Enabled = false;
            }
            else
            {
                switchTimer.Text = "Stop";
                d = randomiser.NextDouble() + 0.08;
                mainTimer.Enabled = true;
            }
        }

        private void mainTimer_Tick(object sender, EventArgs e)
        {
            if (x > ClientSize.Width - 45 || x < 0)
                sx = -sx;
            if (y > ClientSize.Height - 45 || y < 25)
                sy = -sy;
            speed = x / 80 + 1;//                                        ЬЕЬЕЬЕЬЕЬЕЬЕЬЕЬ     AXAXAXAXAXAXAXA    ХИХИХИХИХИХ
            x += (int)(sx * (1.0 / 1 + d) * speed);
            y += (int)(sy * (1.0 / d) * speed);
            Refresh();
        }

        public int Speed
        {
            set { speed = value; }
            get { return speed; }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush brush = new SolidBrush(Color.DarkGoldenrod);
            Graphics drawer = e.Graphics;
            drawer.FillEllipse(brush, x, y, 45, 45);
        }
    }
}
