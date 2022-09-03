using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

abstract class Unit
{
    protected int health;
    protected int walkingSpeed;
    protected int cost;
    protected int damage;
    protected bool isLive;
    protected string name;
    protected int maxHp;

    public Unit(int health, int walkingSpeed, int cost, int damage, string name)
    {
        this.health = health;
        this.walkingSpeed = walkingSpeed;
        this.cost = cost;
        this.damage = damage;
        isLive = true;
        this.name = name;
        maxHp = health;
    }

    public virtual void Attack(Unit unit)
    {
        if (isLive && unit.isLive)
        {
            if (unit.health - damage > 0)
            {
                unit.health -= damage;
                Console.WriteLine($"The {name} attacked the {unit.name}. {unit.health}hp.");
            }
            else
            {
                unit.isLive = false;
                unit.health = 0;
                Console.WriteLine($"the {unit.name} died");
            }
            return;
        }
        Console.WriteLine("the attack failed");
    }

    public virtual void Attack(Footmen footmen)
    {
        if (isLive && footmen.isLive)
        {
            if (footmen.armor - damage >= 0)
            {
                footmen.armor -= damage;
                Console.WriteLine($"The {name} attacked the {footmen.name}. {footmen.health}hp {footmen.armor}armor");
            }
            else if (footmen.armor - damage < 0)
            {
                int temp = footmen.armor - damage;
                footmen.health += temp;
                footmen.armor = 0;
                Console.WriteLine($"The {name} attacked the {footmen.name}. {footmen.health}hp {footmen.armor}armor");

            }
            if (footmen.health - damage <= 0)
            {
                footmen.isLive = false;
                footmen.health = 0;
                Console.WriteLine($"the {footmen.name} died");
            }
            return;
        }
        Console.WriteLine("the attack failed");
    }

    protected void Heal(Unit unit, int manaHeal)
    {
        if (unit.health + manaHeal <= unit.maxHp)
        {
            unit.health += manaHeal;
        }
        else
        {
            unit.health = unit.maxHp;
        }    

        Console.WriteLine($"the {unit.name} has {unit.health} hp");
    }

    public bool getIsLive()
    {
        return isLive;
    }

    public void Move()
    {

    }

    public virtual void getInfo()
    {
        Console.WriteLine($"Name - {name} \n" +
                          $"Health - {health} \n" +
                          $"Damage - {damage} \n" +
                          $"Speed - {walkingSpeed}");
    }
}

