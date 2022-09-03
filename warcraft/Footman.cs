using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace warcraft
{
    class Footman : Unit
    {
        public const int Health = 60;
        private const int WalkedSpeed = 40;
        private const int Cost = 250;
        private const int Damage = 10;
        private const int Armor = 40;

        public int armor = Armor;
        public Footman() : base(Health, WalkedSpeed, Cost, Damage)
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

        public void Rage()
        {
            if (this.health < 15)
            {
                this.damage *= 2;
            }
            else
            {
                this.damage = Footman.Damage;
            }
        }
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"armor: {this.armor}");
        }
    }
}
