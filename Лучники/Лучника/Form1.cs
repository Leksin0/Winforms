using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лучника
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
            btnStart.Hide();
            txbName1.Hide();
            txbName2.Hide();
            lblEnterUrNames.Hide();

            lblArcher1Name.Text = txbName1.Text;
            lblArcher2Name.Text = txbName2.Text;
            Archer1 = new Archer(lblArcher1Name.Text);
            Archer2 = new Archer(lblArcher2Name.Text);
            NowShooting = 1;
            timer1.Enabled = true;

            lblArcher1Name.Show();
            lblArcher2Name.Show();
            lblArcher1Health.Show();
            lblArcher2Health.Show();
            btnArcher1Shot.Show();
            chbArcher1Load.Show();
        }

        private void btnArcher1Shot_Click(object sender, EventArgs e)
        {
            try
            {
                if (NowShooting == 2)
                    throw new Exception("Сейчас стреляет другой игрок");
                if (chbArcher1Load.Checked == false)
                    throw new Exception("Зарядите лук");
                Archer1.Shot(Archer2);
                chbArcher1Load.Checked = false;
                lblArcher2Health.Text = "Здоровье: " + Archer2.life.ToString();
                if (Archer2.Alive == false)
                {
                    timer1.Enabled = false;
                    lblWinner.Text = Archer1.name + " победил!";
                    lblWinner.Show();
                    chbArcher1Load.Hide();
                    btnArcher1Shot.Hide();
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
                if (NowShooting == 1)
                    throw new Exception("Сейчас стреляет другой игрок");
                if (chbArcher2Load.Checked == false)
                    throw new Exception("Зарядите лук");
                Archer2.Shot(Archer1);
                chbArcher2Load.Checked = false;
                lblArcher1Health.Text = "Здоровье: " + Archer1.life.ToString();
                if (Archer1.Alive == false)
                {
                    timer1.Enabled = false;
                    lblWinner.Text = Archer2.name + " победил!";
                    lblWinner.Show();
                    chbArcher1Load.Hide();
                    btnArcher1Shot.Hide();
                    chbArcher2Load.Hide();
                    btnArcher2Shot.Hide();
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