using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWorkLK_W3LG_
{
    internal class Footman : Unit
    {
        public bool IsInRage { get; set; } 
        public Footman() : base(200, 50, "Footman") { }

        public override void ReceiveDamage(int damage)
        {
            base.ReceiveDamage(damage);
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
        }
    }
}
