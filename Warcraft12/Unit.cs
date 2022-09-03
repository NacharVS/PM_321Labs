using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warcraft
{
    abstract class Unit
    {
        protected int health;
        protected int maxHealth;
        protected int movementSpeed;
        private int cost;
        public abstract int damage { get; set; }

        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        public int MaxHealth
        {
            get { return maxHealth; }
        }

        public int MovementSpeed
        {
            get { return movementSpeed; }
        }

        public Unit(int health, int moveSpeed, int cost, int damage) 
        {
            this.health = health;
            this.maxHealth = health;
            this.movementSpeed = moveSpeed;
            this.cost = cost;
            this.damage = damage;
        }

        public abstract void Attack(Unit enemy);

        public virtual bool TakeDamage(int damage)
        {
            this.health -= damage;
            if (this.health <= 0)
            {
                health = 0;
                Console.WriteLine("Smertb\n");
                return false;
            }
            return true;
        }

        protected void Move() { }
    }
}
