using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWorkLK_W3LG_
{
    class program
    {
        static void Main(string[] args)
        {
            Footman footman = new Footman();
            Peasant peasant = new Peasant();
            Mage mage = new Mage();
            Console.WriteLine(mage.Mana);
            mage.HealthChangedEvent += Info;
            footman.HealthChangedEvent += Info;
            peasant.HealthChangedEvent += Info;
            mage.Attack(footman);
            footman.Attack(mage);
            footman.Attack(mage);
            footman.Attack(peasant);
            Blacksmith blacksmith = new Blacksmith();
            blacksmith.Upgrade();/*
            Footman footman1 = new Footman();
            Peasant peasant1 = new Peasant();
            Mage mage1 = new Mage();
            mage.HealthChangedEvent += Info;
            footman.HealthChangedEvent += Info;
            peasant.HealthChangedEvent += Info;
            mage1.Attack(footman1);
            footman1.Attack(mage1);
            footman1.Attack(mage1);
            footman1.Attack(peasant1);*/
            mage.Attack(footman);
            footman.Attack(mage);
            footman.Attack(mage);
            footman.Attack(peasant);
            Console.WriteLine(Unit.level);
            blacksmith.Upgrade();
            Footman footman1 = new Footman();
            mage.Attack(footman);
            footman1.Attack(mage);
            footman1.Attack(mage);
            footman.Attack(peasant);
            blacksmith.Upgrade();
            Console.WriteLine(mage.Mana);
        }

        static void Info(int health, int maxHealth, int currentHealth, string Name)
        {
            if (health < currentHealth)
            {
                Console.WriteLine($"{Name} Recieved damage {currentHealth - health} ({maxHealth}/{health})");
            }
            else if (health > currentHealth)
            {
                Console.WriteLine($"{Name} Healed health {health - currentHealth} ({maxHealth}/{health})");
            }
        }

        static void Rage()
        {
            Console.WriteLine("asd");
        }
    }
}