using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace warcraft
{
    class Pessant : Unit
    {
        public const int Health = 40;
        private const int WalkedSpeed = 30;
        private const int Cost = 150;
        private const int Damage = 5;


        public Pessant() : base(Health, WalkedSpeed, Cost, Damage)
        {
            if (resource < Cost)
            {
                Console.WriteLine("Не хватило денег");
                this.isLive = false;
            }
            else
            {
                resource -= Cost;
            }
        }

        public void Mining()
        {
            if (this.isLive)
            {
                resource += 100;
                Console.WriteLine($"+100 ресурсов. Всего: {resource}");
            }
        }

        public void Build()
        {

        }

        public void Cancel()
        {

        }
    }
}
