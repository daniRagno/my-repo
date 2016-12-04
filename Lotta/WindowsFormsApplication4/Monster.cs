using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Lotta
{
    class Monster
    {
        public string name;
        public int maxHp;
        public int curHp;
        public int damage;
        public int healHp;

        public Monster(string name, int maxHp, int damage, int healHp)
        {
            this.name = name;
            this.maxHp = maxHp;
            curHp = maxHp;
            this.damage = damage;
            this.healHp = healHp;
            describe();
        }

        public string describe()
        {
           string output = " Questo è " + name + "\r\n";
           output += " Hp :" + maxHp + "\r\n";
           output += "Damage: " + damage + "\r\n";

            return output;
        }

        public void describe(TextBox t)
        {
            t.Text = describe();

        }

        public void attack(Monster target)
        {
            if (target.curHp <= 0)
            {
                Console.WriteLine(target.name + " è già esausto, non infierire.");
                return;
            }

            Console.WriteLine(name + " attacca " + target.name);
            Console.WriteLine(name + " fa " + damage + " danni a " + target.name);
            target.curHp -= damage;

            if (target.curHp <= 0)
            {
                target.curHp = 0;
                Console.WriteLine(target.name + " è esausto.");
                return;
            }
            else
            {
                Console.WriteLine("a " + target.name + " rimangono " + target.curHp + " hp");
            }

        }

        public void heal()
        {
            if (curHp >= maxHp)
            {
                Console.WriteLine(name + " è già al massimo della vita.");
                return;
            }

            Console.WriteLine(name + " si cura. ");
            Console.WriteLine(name + " recupera " + healHp + " HP.");
            curHp += healHp;

            if (curHp >= maxHp)
            {
                curHp = maxHp;
                Console.WriteLine(name + " ha recuperato tutta la vita.");
            }
            else
            {
                Console.WriteLine("a " + name + " rimangono " + curHp + " hp");
            }

        }
    }
}
