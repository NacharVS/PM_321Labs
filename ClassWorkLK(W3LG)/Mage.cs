using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWorkLK_W3LG_
{
    internal class Mage : Unit
    {
        protected int Mana { get; set; }
        protected int MaxMana { get; set; }

        public Mage(int mana) : base(150, 80, "Mage")
        {
            this.Mana = mana;
        }
        public Mage() : base(150, 80, "Mage")
        {
            this.Mana = 10000;
            this.MaxMana = this.Mana;
        }

        public void Heal(Unit unit)
        {
            if (!unit.IsAlive || !this.IsAlive)
            {
                return;
            }
            int CurrentHealth = unit.Health;
            if ((unit.MaxHealth - unit.Health) * 6 > this.Mana)
            {
                unit.Health += this.Mana / 6;
                this.Mana = this.Mana % 6;
            }
            else
            {
                this.Mana -= (unit.MaxHealth - unit.Health) * 6;
                unit.Health = unit.MaxHealth;
            }
            Console.WriteLine($"{this.Name} healed {unit.Health - CurrentHealth} health to {unit.Name}({unit.MaxHealth}/{unit.Health})");
        }
    }
}
