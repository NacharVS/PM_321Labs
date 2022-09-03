using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warcraft
{
    internal class Peasant : Unit
    {
        static int baseHealth = 100;
        static int baseMoveSpeed = 15;
        static int baseCost = 50;
        static int baseDamage = 1;

        public override int damage { get; set; }

        public Peasant() : base(baseHealth, baseMoveSpeed, baseCost, baseDamage) { }

        public override void Attack(Unit enemy) 
        {
            enemy.TakeDamage(this.damage);
            Console.WriteLine($"Peasant attacked enemy");
            Console.WriteLine($"Peasant health {this.health}");
            Console.WriteLine($"Enemys health {enemy.Health}");
            Console.WriteLine();
        }

        public void Build() { }

        public void Mine() { }

        public void Repair() { }
    }
}
