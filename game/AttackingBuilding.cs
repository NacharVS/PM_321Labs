using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

abstract class AttackingBuilding : Building
{
    protected int damage;
    protected int range;
    protected int armor;

    public AttackingBuilding(int health, int cost, int timeSec, int damage, int range, int armor, string name) : base(health, cost, timeSec, name)
    {
        this.damage = damage;
        this.range = range;
        this.armor = armor;
    }

    public virtual void Attack(Unit unit)
    {
        if (isLive && unit.getIsLive())
        {
            int unitHealth = unit.getHealth();

            if (unitHealth - damage > 0)
            {
                unitHealth -= damage;
                unit.setHealth(unitHealth);
                Console.WriteLine($"The {name} attacked the {unit.getName}. {unitHealth}hp.");
            }
            else
            {
                unit.setHealth(unitHealth);
                Console.WriteLine($"the {unit.getName} died");
            }
            return;
        }
        Console.WriteLine("the attack failed");
    }

    public virtual void Attack(Footman footmen)
    {
        if (isLive && footmen.getIsLive())
        {
            int unitHealth = footmen.getHealth();

            if (footmen.armor - damage >= 0)
            {
                footmen.armor -= damage;
                Console.WriteLine($"The {name} attacked the {footmen.getName}. {unitHealth}hp {footmen.armor}armor");
            }
            else if (footmen.armor - damage < 0)
            {
                int temp = footmen.armor - damage;
                unitHealth += temp;
                footmen.setHealth(unitHealth);
                footmen.armor = 0;
                Console.WriteLine($"The {name} attacked the {footmen.getName}. {unitHealth}hp {footmen.armor}armor");

            }
            return;
        }
        Console.WriteLine("the attack failed");
    }

    public override void Upgrade()
    {
        
    }
}
