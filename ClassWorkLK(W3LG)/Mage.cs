using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWorkLK_W3LG_
{
    internal class Mage : Unit
    {
        public static int health = 1500;
        public static int damage = 80;
        public static int mana = 10000;
        public static int defense = 5;

        public int Mana { get; set; }
        public int MaxMana { get; set; }

        public Mage(int mana) : base(health, damage, defense, "Mage")
        {
            this.Mana = mana;
        }
        public Mage() : base(health, damage, defense, "Mage")
        {
            this.Mana = mana;
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
