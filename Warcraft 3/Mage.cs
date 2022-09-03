using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warcraft_3
{
    class Mage : Unit
    {
        int Mana = 100;
        public Mage() : base(50, 300, 300, 15)
        {

        }

        static public void TargetHeal(int Health, int Mana)
        {
            Console.WriteLine("Лечит");
            Health += 25;
            Mana -= 50;
        }

        public void Attack(Unit unit)
        {
            if (this.Health > 0)
            {
                if (this.Health <= 25)
                {
                    Mage.TargetHeal(Health, Mana);
                }

                unit.Health -= this.Damage;
            }

            else
            {
                Console.WriteLine("Распылился");
                this.Health = 0;
            }

        }
    }
}
