using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Mage : Unit
{
    protected int mana;
    const int manaWaste = 15;
    const int manaDamage = 40;
    const int manaHeal = 10;

    public Mage(int health, int walkingSpeed, int cost, int mana, int damage, string name) : base(health, walkingSpeed, cost, damage, name)
    { 
        this.mana = mana;
    }

    public Mage() : base(100, 20, 180, 25, "Mage")
    {
        mana = 100;
    }

    public void AttackFireBall(Unit unit)
    {
        if (mana - manaWaste >= 0)
        {
            int origDamag = damage;
            damage = manaDamage;
            base.Attack(unit);
            mana -= manaWaste;
            damage = origDamag;
        }
    }

    public void AttackFireBall(Footman footmen)
    {
        if (mana - manaWaste >= 0)
        {
            int origDamag = damage;
            damage = manaDamage;
            base.Attack(footmen);
            mana -= manaWaste;
            damage = origDamag;
        }
    }

    public void TargetHeal(Unit unit)
    {
        if (unit.getIsLive() && isLive)
        {
            if (mana - manaWaste >= 0)
            {
                Heal(unit, manaHeal);
                mana -= manaWaste;
            }
        }
    }

    public override void getInfo()
    {
        base.getInfo();
        Console.WriteLine($"Mana - {mana} \n" +
                          $"Mana damage - {manaDamage} \n" +
                          $"Mana heal - {manaHeal} \n");
    }
}
