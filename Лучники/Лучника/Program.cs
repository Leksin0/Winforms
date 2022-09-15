using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лучника
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    class Archer
    {
        public string name;
        int shots;
        int totalAttack;
        int defence;
        int totalLife;
        public int life;
        public Archer(string name)
        {
            this.name = name;
            shots = 100;
            totalLife = 100;
            life = 100;
            totalAttack = 10;
        }
        float LifePercent
        {
            get
            {
                return (float)life / totalLife;
            }
        }
        int Attack
        {
            get
            {
                return (int)Math.Ceiling(totalAttack * LifePercent);
            }
        }
        public bool Alive
        {
            get
            {
                return life > 0 ? true : false;
            }
        }
        void Damaged(int dmg)
        {
            life -= dmg;
            if(life < 0)
                life = 0;
        }
        public void Shot(Archer target)
        {
            try
            {
                if (shots < 0)
                    throw new Exception("Стрелы кончились");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            target.Damaged(Attack);
        }
    }
}