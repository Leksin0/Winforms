using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

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
        string name;
        int shots;
        int totalAttack;
        int defence;
        int totalLife;
        int life;
        Archer(string name)
        { this.name = name;
        }
        int LifePercent { get { return life / totalLife; } }
        int Attack { get { return totalAttack * LifePercent; } }
        bool Alive { get { return life > 0 ? true : false; } }
        void Damaged(int dmg) { life -= dmg; }
        static void Shot(Archer target) { target.Damaged(1); }
    }
}
