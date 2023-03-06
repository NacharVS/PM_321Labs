using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace warcraft
{
    class BlackSmith
    {
        const int cost = 400;
        bool isWorking;
        public static int upgradeDamage;
        public static int upgradeArmor;
        public static int upgradeBow;

        public BlackSmith()
        {
            if (Unit.resource < cost)
            {
                Console.WriteLine("Не хватило денег");
            }
            else
            {
                Unit.resource -= cost;
                this.isWorking = true;
            }
        }

        public void UpgradeDamage()
        {
            if (isWorking && upgradeDamage < 3)
            {
                ++upgradeDamage;
                foreach (Unit unit in Unit.Units)
                {
                    unit.damage += 5;
                }
            }
        }

        public void UpgradeArmor()
        {
            if (isWorking && upgradeArmor < 3)
            {
                ++upgradeArmor;
                foreach (Footman footman in Footman.Footmans)
                {
                    footman.armor += 5;
                }
            }
        }

        public void UpgradeBow()
        {
            if (isWorking && upgradeBow < 3)
            {
                ++upgradeBow;
                foreach (Archer archer in Archer.Archers)
                {
                    ++archer.arrowCount;
                }
            }
        }
    }
}
