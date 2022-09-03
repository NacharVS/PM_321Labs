using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warcraft_3
{
    class Footman : Unit
    {
        int Armor = 5;
        public Footman() : base(100, 250, 200, 10)
        {

        }

        static public void Rage(int Damage)
        {
            Damage += 5;
        }

        public void Attack(Unit unit)
        {
            if (this.Health > 0)
            {
                if (this.Health <= 25)
                {
                    Console.WriteLine("Впадает в ярость");
                    Footman.Rage(Damage);
                }

                unit.Health -= this.Damage;
            }

            else
            {
                Console.WriteLine("Пал в бою");
                this.Health = 0;
            }

        }
    }
}
