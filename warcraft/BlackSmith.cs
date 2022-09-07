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
        static int upgradeDamage;
        static int upgradeArmor;
        static int upgradeBow;

        public BlackSmith()
        {
            if (Unit.resource > cost)
            {
                isWorking = true;
            }
        }

        public void UpgradeDamage()
        {
            if (isWorking && upgradeDamage < 3)
            {
                ++upgradeDamage;
            }
        }

        public void UpgradeArmor()
        {
            if (isWorking && upgradeArmor < 3)
            {
                ++upgradeArmor;
            }
        }

        public void UpgradeBow()
        {
            if (isWorking && upgradeBow < 3)
            {
                ++upgradeBow;
            }
        }
    }
}
