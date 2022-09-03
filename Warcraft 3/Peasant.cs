using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warcraft_3
{
    class Peasant : Unit
    {
        public Peasant() : base(20, 100, 50, 5)
        {

        }

        public static void Mining()
        {
            Console.WriteLine("Добывает");
        }

        public static void Build()
        {
            Console.WriteLine("Строит");
        }

        public static void Cancel()
        {
            Console.WriteLine("Отменяет");
        }

        public void Attack(Unit unit)
        {
            if (this.Health > 0)
            {
                unit.Health -= this.Damage;
            }

            else
            {
                Console.WriteLine("Работяга погиб");
                this.Health = 0;
            }

        }
    }
}
