using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Footmen : Unit
{
    public int armor;
    private int constDamage = 30;

    public Footmen(int health, int walkingSpeed, int cost, int armor, int damage, string name) : base(health, walkingSpeed, cost, damage, name)
    {
        this.armor = armor;
        constDamage = damage;
    }

    public Footmen() : base(60, 15, 70, 30, "Footmen")
    {
        armor = 100;
        constDamage = 30;
    }

    public override void Attack(Footmen footmen)
    {
        Rage();
        base.Attack(footmen);
    }

    public override void Attack(Unit unit)
    {
        Rage();
        base.Attack(unit);
    }

    private void Rage()
    {
        if (health < 15)
        {
            damage = constDamage * 2;
        }

        else if (health >= 30)
        {
            damage = constDamage;
        }
    }

    public override void getInfo()
    {
        base.getInfo();
        Console.WriteLine($"Armor - {armor} \n");
    }
}
