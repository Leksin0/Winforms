using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лучники
{
    public partial class Form1 : Form
    {
        Archer Archer1;
        Archer Archer2;
        int NowShooting;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            grpStarterControls.Hide();

            lblArcher1Name.Text = txbName1.Text;
            lblArcher2Name.Text = txbName2.Text;
            Archer1 = new Archer(lblArcher1Name.Text);
            Archer2 = new Archer(lblArcher2Name.Text);
            NowShooting = 1;
            timer1.Enabled = true;
        }

        private void btnArcher1Shot_Click(object sender, EventArgs e)
        {
            try
            {
                if (chbArcher1Load.Checked == false)
                    throw new Exception("Зарядите лук");
                Archer1.Shot(Archer2);
                chbArcher1Load.Checked = false;
                lblArcher2Health.Text = "Здоровье: " + Archer2.Life.ToString();
                lblArcher1Arrows.Text = "Стрелы: " + Archer1.Arrows.ToString();
                if (Archer2.Alive == false)
                {
                    timer1.Enabled = false;
                    lblWinner.Text = Archer1.Name + " победил!";
                    lblWinner.Show();
                    chbArcher1Load.Hide();
                    btnArcher1Shot.Hide();
                    lblArcher1Arrows.Hide();
                    lblArcher2Arrows.Hide();
                    chbArcher2Load.Hide();
                    btnArcher2Shot.Hide();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnArcher2Shot_Click(object sender, EventArgs e)
        {
            try
            {
                if (chbArcher2Load.Checked == false)
                    throw new Exception("Зарядите лук");
                Archer2.Shot(Archer1);
                chbArcher2Load.Checked = false;
                lblArcher1Health.Text = "Здоровье: " + Archer1.Life.ToString();
                lblArcher2Arrows.Text = "Стрелы: " + Archer2.Arrows.ToString();
                if (Archer1.Alive == false)
                {
                    timer1.Enabled = false;
                    lblWinner.Text = Archer2.Name + " победил!";
                    lblWinner.Show();
                    chbArcher1Load.Hide();
                    btnArcher1Shot.Hide();
                    lblArcher1Arrows.Hide();
                    chbArcher2Load.Hide();
                    btnArcher2Shot.Hide();
                    lblArcher2Arrows.Hide();
                }
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            NowShooting = 3 - NowShooting;
            if (NowShooting == 1)
            {
                chbArcher2Load.Hide();
                btnArcher2Shot.Hide();
                chbArcher1Load.Show();
                btnArcher1Shot.Show();
            }
            else
            {
                chbArcher1Load.Hide();
                btnArcher1Shot.Hide();
                chbArcher2Load.Show();
                btnArcher2Shot.Show();
            }
        }
    }
}