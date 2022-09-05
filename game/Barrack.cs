using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Barrack : Building
{
    private int lvlDamage;
    private int lvlArmor;
    private int lvlBow;

    public Barrack() : base(1500, 160, 60, "Barrack")
    {
        lvlDamage = 1;
        lvlArmor = 1;
        lvlBow = 1;
    }

    public void UpgradeDamage()
    {
        if (lvlDamage < 4)
        {
            int damage;

            foreach (var i in Unit.list)
            {
                damage = i.getDamage();
                i.setDamage(damage + 10);
            }
            lvlDamage++;
        }
    }

    public void UpgradeArmor()
    {
        if (lvlArmor < 4)
        {
            foreach (var i in Unit.list)
            {
                try
                {
                    var footmen = (Footman)i;
                    footmen.armor += 10;
                }
                catch { }
            }
            lvlArmor++;
        }
    }

    public void UpgradeBow()
    {
        if (lvlBow < 4)
        {
            foreach (var i in Unit.list)
            {
                try
                {
                    var archer = (Archer)i;
                    archer.range += 5;
                }
                catch { }
            }
            lvlBow++;
        }
    }
}

