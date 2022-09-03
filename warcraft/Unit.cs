using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace warcraft
{
    abstract class Unit
    {
        protected static int resource = 2000;
        public int health;
        int walkedSpeed;
        int cost;
        protected int damage;
        public bool isLive;

        public Unit(int health, int walkedSpeed, int cost, int damage)
        {
            this.health = health;
            this.walkedSpeed = walkedSpeed;
            this.cost = cost;
            this.damage = damage;
            this.isLive = true;
        }

        public void Move()
        {

        }

        public virtual void Attack(Unit attackedPlayer)
        {
            if (attackedPlayer.isLive && this.isLive)
            {
                if (attackedPlayer.health - this.damage > 0)
                    attackedPlayer.health -= this.damage;
                else
                {
                    attackedPlayer.health = 0;
                    attackedPlayer.isLive = false;
                }
                Console.WriteLine($"атакующий - {this.GetType()}");
                this.GetInfo();
                Console.WriteLine($"атакуемый - {attackedPlayer.GetType()}");
                attackedPlayer.GetInfo();
            }
        }

        public virtual void Attack(Footman attackedPlayer)
        {
            if (attackedPlayer.isLive && this.isLive)
            {
                if ((attackedPlayer.health + attackedPlayer.armor) - this.damage > 0)
                {
                    if (attackedPlayer.armor - this.damage < 0)
                    {
                        int tmp = this.damage - attackedPlayer.armor;
                        attackedPlayer.armor = 0;
                        attackedPlayer.health -= tmp;
                        attackedPlayer.Rage();
                    }
                    else
                        attackedPlayer.armor -= this.damage;
                }
                else
                {
                    attackedPlayer.health = 0;
                    attackedPlayer.isLive = false;
                }
                Console.WriteLine($"атакующий - {this.GetType()}");
                this.GetInfo();
                Console.WriteLine($"атакуемый - Footman");
                attackedPlayer.GetInfo();
            }
        }

        public virtual void GetInfo()
        {
            Console.WriteLine($"HP: {this.health}\n" +
                              $"walk speed: {this.walkedSpeed}\n" +
                              $"cost: {this.cost}\n" +
                              $"damage: {this.damage}\n" +
                              $"live: {this.isLive}");
        }
    }
}
