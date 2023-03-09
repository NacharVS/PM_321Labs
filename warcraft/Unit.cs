﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace warcraft
{
    abstract class Unit
    {
        public static List<Unit> Units = new List<Unit>(); 
        public delegate void GetDamageDelegate(int Damage);
        public event GetDamageDelegate GetDamageEvents;

        public static int resource = 2000;
        public int health;
        int walkedSpeed;
        int cost;
        public int damage;
        public bool isLive;

        public Unit(int health, int walkedSpeed, int cost, int damage)
        {
            this.health = health;
            this.walkedSpeed = walkedSpeed;
            this.cost = cost;
            this.damage = damage + 5*BlackSmith.upgradeDamage;
            this.isLive = true;
            Units.Add(this);
            GetDamageEvents += GetDamage;
        }

        public void Move()
        {

        }

        static void GetDamage(int Damage)
        {
            Console.WriteLine($"Получено урона - {Damage}");
        }

        public virtual void Attack(Unit attackedPlayer)
        {
            if (attackedPlayer.isLive && this.isLive)
            {
                if (attackedPlayer.health - this.damage > 0)
                {
                    attackedPlayer.health -= this.damage;
                    GetDamageEvents?.Invoke(this.damage);
                }
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
                        attackedPlayer.HealthRe -= tmp;
                        GetDamageEvents?.Invoke(this.damage);
                    }
                    else
                    {
                        attackedPlayer.armor -= this.damage;
                        GetDamageEvents?.Invoke(this.damage);
                    }
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