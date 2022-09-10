using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWorkLK_W3LG_
{
    internal class Blacksmith : Building
    {
        public void Upgrade()
        {
            if(Unit.level > 3)
            {
                return;
            }
            Unit.level += 1;
            UpgradeFootman();
            UpgradeMage();
            UpgradePeasant();
            foreach (Unit unit in Unit._unitList)
            {
                UpgradeUnit(unit);
                Console.WriteLine(unit.Name);
            }
        }

        public void UpgradeFootman()
        {
            Footman.health += 50;
            Footman.damage += 10;
        }
        public void UpgradeFootman(Footman unit)
        {
            unit.MaxHealth += 50;
            unit.Health += 50;
            unit.BaseDamage += 10;
            unit.Damage += 10;
        }
        public void UpgradeMage()
        {
            Mage.health += 20;
            Mage.damage += 5;
            Mage.mana += 25;
        }
        public void UpgradeMage(Mage unit)
        {
            unit.MaxHealth += 20;
            unit.Health += 20;
            unit.BaseDamage += 5;
            unit.Damage += 5;
            unit.MaxMana += 25;
            unit.Mana += 25;
        }
        public void UpgradePeasant()
        {
            Peasant.health += 20;
            Peasant.damage += 5;
        }
        public void UpgradePeasant(Peasant unit)
        {
            unit.MaxHealth += 20;
            unit.Health += 20;
            unit.BaseDamage += 5;
            unit.Damage += 5;
        }
        public void UpgradeArcher()
        {
            Archer.health += 30;
            Archer.damage += 40;

        }
        public void UpgradeArcher(Archer unit)
        {
            unit.MaxHealth += 20;
            unit.Health += 20;
            unit.BaseDamage += 5;
            unit.Damage += 5;
        }
        public void UpgradeSword()
        {
            Sword.damage += 10;

        }
        public void UpgradeSword(Sword equipment)
        {
            equipment.Damage += 10;
        }
        public void UpgradeBowe()
        {
            Bow.damage += 10;

        }
        public void UpgradeBow(Bow equipment)
        {
            equipment.Damage += 10;
        }
        public void UpgradeQuiver()
        {
            Quiver.arrowsCount += 10;

        }
        public void UpgradeQuiver(Quiver equipment)
        {
            equipment.arrows += 10;
        }
        public void UpgradeChainMail()
        {
            ChainMail.defense += 10;

        }
        public void UpgradeChainMail(ChainMail equipment)
        {
            equipment.Defense += 10;
        }
        public void UpgradeUnit(Unit unit)
        {
            switch (unit.Name)
            {
                case "Archer": UpgradeArcher((unit as Archer)); break;
                case "Footman": UpgradeFootman((unit as Footman)); break;
                case "Mage": UpgradeMage((unit as Mage)); break;
                case "Peasant": UpgradePeasant((unit as Peasant)); break;
                default: break;
            }
        }
        public void UpgradeWeapon(Equipment equipment)
        {
            switch (equipment.Name)
            {
                case "Sword": UpgradeSword((equipment as Sword)); break;
                case "Bow": UpgradeBow((equipment as Bow)); break;
                case "Quiver": UpgradeQuiver((equipment as Quiver)); break;
                case "ChainMail": UpgradeChainMail((equipment as ChainMail)); break;
                default: break;
            }
        }
    }
}
