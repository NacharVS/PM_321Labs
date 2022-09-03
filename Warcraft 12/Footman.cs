using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warcraft
{
    internal class Footman : Unit
    {
        static int baseHealth = 170;
        static int baseMoveSpeed = 50;
        static int baseCost = 70;
        static int baseDamage = 25;

        protected int armor = 6;
        protected bool rage;
        public override int damage { get; set; }

        public Footman() : base(baseHealth, baseMoveSpeed, baseCost, baseDamage) { }

        public override void Attack(Unit enemy) 
        {
            enemy.TakeDamage(this.damage);
            Console.WriteLine($"Footman attacked enemy");
            Console.WriteLine($"Footmans health {this.health}");
            Console.WriteLine($"Enemys health {enemy.Health}");
            Console.WriteLine();
        }

        public override bool TakeDamage(int damage)
        {
            this.health -= (damage - armor);
            if (this.health <= 0)
            {
                health = 0;
                Console.WriteLine("Footman dead\n");
                rage = false;
                damage = baseDamage;
                return true;
            }
            if (rage == false && this.health <= (baseHealth * 0.2))
            { 
                rage = true;
                this.damage *= 2;
                Console.WriteLine("Rage\n");
            }
            return true;
        }
    }
}
