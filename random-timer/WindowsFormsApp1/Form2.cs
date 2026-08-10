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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Program.MainForm.Speed = trackBar1.Value;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            trackBar1.Value = Program.MainForm.Speed;
        }
    }
}
