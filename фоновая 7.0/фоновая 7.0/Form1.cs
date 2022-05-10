using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace фоновая_7._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
       

        }

        private void A_Click(object sender, EventArgs e)
        {
            //label1.Hide();
            if (B.Top > 10)
                B.Top -= 10;
            else
                B.Top -= B.Top;
            label1.Text = Convert.ToString(B.Top);
        }

        private void B_Click(object sender, EventArgs e)
        {
            //label1.Hide();
            if (Height - B.Top - B.Height > 10)
                B.Top += 10;
            else
                B.Top += Height - B.Top - B.Height - 10;
            label1.Text = Convert.ToString(B.Top);

        }
    }
}
