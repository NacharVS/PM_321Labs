using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWorkLK_W3LG_
{
    internal class Unit
    {
        public int Health { get; set; }
        public int MaxHealth { get; set; }
        public int Damage { get; set; }
        public int BaseDamage { get; set; }
        public string Name { get; set; }
        public bool IsAlive { get; set; }

        public Unit(int health, int damage, string name)
        {
            this.Health = health;
            this.MaxHealth = this.Health;
            this.Damage = damage;
            this.BaseDamage = Damage;
            this.Name = name;
            this.IsAlive = true;
        }
        public Unit()
        {
            this.Health = 60;
            this.MaxHealth = this.Health;
            this.Damage = 10;
            this.Name = "Unit";
            this.IsAlive = true;
        }

        public void Attack(Unit unit)
        {
            if (!this.IsAlive || !unit.IsAlive)
            {
                return;
            }
            Console.WriteLine($"\n{this.Name} attacking {unit.Name} dealing {this.Damage}");
            unit.ReceiveDamage(this.Damage);
            if (!this.IsAlive || !unit.IsAlive)
            {
                return;
            }
            this.ReceiveDamage(unit.Damage);
        }

        public virtual void ReceiveDamage(int damage)
        {
            if (!this.IsAlive)
            {
                return;
            }
            if (damage >= this.Health)
            {
                this.Health -= damage;
                Console.WriteLine($"{this.Name} received {damage} damage({this.MaxHealth}/{this.Health})");
                this.IsAlive = false;
                Console.WriteLine($"\n{this.Name} died\n");
                return;
            }
            this.Health -= damage;
            Console.WriteLine($"{this.Name} received {damage} damage({this.MaxHealth}/{this.Health})");
        }
    }
}
