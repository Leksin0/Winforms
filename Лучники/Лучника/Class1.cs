using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Лучники
{
    class Archer
    {
        string name;
        int shots;
        int totalAttack;
        int defence;
        int totalLife;
        int life;
        public Archer(string name)
        {
            this.name = name;
            shots = 50;
            totalLife = 100;
            life = 100;
            totalAttack = 10;
        }
        public int Arrows
        {
            get
            {
                return shots;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
        }
        public int Life
        {
            get
            {
                return life;
            }
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
            if (life < 0)
                life = 0;
        }
        public void Shot(Archer target)
        {
            try
            {
                if (shots < 0)
                    throw new Exception("Стрелы кончились");
                target.Damaged(Attack);
                shots--;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
