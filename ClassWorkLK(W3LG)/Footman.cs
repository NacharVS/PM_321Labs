using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWorkLK_W3LG_
{
    internal class Footman : Unit
    {
        public static int health = 2000;
        public static int damage = 50;
        public static int defense = 10;

        public bool IsInRage { get; set; } 
        public Footman() : base(health, damage, defense, "Footman") 
        {
            this.Weapon = new Sword();
            this.Armor = new ChainMail();
        }

        /*public void Rage(int damage)
        {
            if (this.Health < this.MaxHealth * 0.4 && !this.IsInRage)
            {
                Console.WriteLine($"\n{this.Name} is in rage\n");
                this.IsInRage = true;
                this.Damage = (int)(this.Damage * 1.2);
            }
            if (this.Health > this.MaxHealth * 0.4 && this.IsInRage)
            {
                Console.WriteLine($"\n {this.Name} calmed down\n");
                this.IsInRage = false;
                this.Damage = this.BaseDamage;
            }
        }*/
    }
}
