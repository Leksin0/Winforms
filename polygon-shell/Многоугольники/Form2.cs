using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Многоугольники
{
    public partial class FormSize : Form
    {
        public FormSize()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        public int Size
        {
            get{ return trackBar1.Value; }   
        }

        private void FormSize_Load(object sender, EventArgs e)
        {
            trackBar1.Value = Vertex.Size;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            trackBar1.Value = 35;
        }
    }
}
