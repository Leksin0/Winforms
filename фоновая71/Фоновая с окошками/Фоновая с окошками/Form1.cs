using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Фоновая_с_окошками
{
    public partial class Form1 : Form
    {
        bool ok1;
        bool ok2;
        Triangle maintriangle;
        public Form1()
        {
            InitializeComponent();
            ok1 = false;
            ok2 = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Rectangular_CheckedChanged(object sender, EventArgs e)
        {
            if (Rectangular.Checked)
            {

            }
        }

        private void Ravnostr_CheckedChanged(object sender, EventArgs e)
        {
            if (Ravnostr.Checked)
            {

            }
        }

        private void Manually_CheckedChanged(object sender, EventArgs e)
        {




        }

        private void Automaticaly_CheckedChanged(object sender, EventArgs e)
        {




        }

        private void Generate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ok1)
                    throw new Exception("Выберите тип треугольника");
                if (!ok2)
                    throw new Exception("Выберите вариант создания");
                if (true)
                    
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }



        }
    }
}
