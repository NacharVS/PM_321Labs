using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassWorkLK_W3LG_
{
    internal class Unit
    {
        public static List<Unit> _unitList = new List<Unit>();

        public static int level = 1;

        public delegate void HealthChangedDelegate(int health, int maxHealth, int currentHealth, string Name);

        public int _health { get; set; }
        public int Health
        {
            get
            {
                return _health;
            }
            set
            {
                int currentHealth = _health;
                _health = value;
                HealthChangedEvent?.Invoke(_health, MaxHealth, currentHealth, this.Name);
            }
        }
        public int MaxHealth { get; set; }
        public int Damage { get; set; }
        public int BaseDamage { get; set; }
        public string Name { get; set; }
        public bool IsAlive { get; set; }
        public int Defense { get; set; }
        public Weapon Weapon { get; set; }
        public Armor Armor { get; set; }

        public Unit(int health, int damage, int defense, string name)
        {
            this.Health = health;
            this.MaxHealth = this.Health;
            this.Damage = damage;
            this.Defense = defense;
            this.BaseDamage = Damage;
            this.Name = name;
            this.IsAlive = true;
            _unitList.Add(this);
        }
        public Unit()
        {
            this.Health = 60;
            this.MaxHealth = this.Health;
            this.Damage = 10;
            this.Name = "Unit";
            this.IsAlive = true;
            _unitList.Add(this);
        }

        public virtual void Attack(Unit unit)
        {
            int unitDamage = unit.Damage;
            int thisDamage = this.Damage;
            if (unit.Weapon != null)
            {
                unitDamage += unit.Weapon.Damage;
            }
            if (this.Weapon != null)
            {
                thisDamage += this.Weapon.Damage;
            }
            if (!this.IsAlive || !unit.IsAlive)
            {
                return;
            }
            Console.WriteLine($"\n{this.Name} attacking {unit.Name} dealing {thisDamage}");
            unit.ReceiveDamage(thisDamage);
            if (!this.IsAlive || !unit.IsAlive)
            {
                return;
            }
            this.ReceiveDamage(unitDamage);
        }

        public virtual void ReceiveDamage(int damage)
        {
            damage -= this.Defense;
            if (!this.IsAlive)
            {
                return;
            }
            if (this.Armor != null)
            {
                damage -= this.Armor.Defense;
            }
            if(damage < 0)
            {
                damage = 0;
            }
            if (damage >= this.Health)
            {
                this.Health -= (damage);/*
                Console.WriteLine($"{this.Name} received {damage} damage({this.MaxHealth}/{this.Health})");*/
                this.IsAlive = false;
                Console.WriteLine($"\n{this.Name} died\n");
                return;
            }
            this.Health -= damage;/*
            Console.WriteLine($"{this.Name} received {damage} damage({this.MaxHealth}/{this.Health})");*/
        }


        public event HealthChangedDelegate HealthChangedEvent;
    }
}
