using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warcraft
{
    internal class Mage : Unit
    {
        static int baseHealth = 110;
        static int baseMoveSpeed = 30;
        static int baseCost = 110;
        static int baseDamage = 40;

        protected int manaPool = 150;
        public override int damage { get; set; }

        public Mage() : base(baseHealth, baseMoveSpeed, baseCost, baseDamage) { }

        public override void Attack(Unit enemy) 
        {
            enemy.TakeDamage(this.damage);
            Console.WriteLine($"Mage attacked enemy");
            Console.WriteLine($"Mage health {this.health}");
            Console.WriteLine($"Enemys health {enemy.Health}");
            Console.WriteLine();
        }

        public override bool TakeDamage(int damage)
        {
            this.health -= damage;
            if (this.health <= 0)
            {
                health = 0;
                Console.WriteLine("Mage dead\n");
                return false;
            }
            if (this.health < baseHealth * 0.25)
            {
                TargetHeal(this);
            }
            return true;

        }

        public void TargetHeal(Unit alies)
        {
            int manaCost = 50;
            if (this.manaPool >= manaCost) this.manaPool -= 50;
            else return;
            if (alies.Health > 0)
            {
                alies.Health += 25;
                if (alies.Health > alies.MaxHealth) alies.Health = alies.MaxHealth;
            }
            
            Console.WriteLine($"Mage Heal");
            Console.WriteLine($"Aliess health {alies.Health}");
            Console.WriteLine();
        }

    }
}
