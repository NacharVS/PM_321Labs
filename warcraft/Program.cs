using warcraft;

Footman footman2 = new Footman();
Footman footman = new Footman();
Mage mage = new Mage();
Mage mage2 = new Mage();
//Footman footman = new Footman();
//Pessant pessant = new Pessant();
//Pessant pessant2 = new Pessant();
//Pessant pessant3 = new Pessant();
//Archer archer = new Archer();
//BlackSmith bs = new BlackSmith();
//footman.GetInfo();
//bs.UpgradeDamage();
//bs.UpgradeArmor();
//footman.GetInfo();
//new Footman().GetInfo();

Task.Run(() => BattleMage(mage, mage2));
Task.Run(() => BattleMage(mage2, mage)).Wait();


static void BattleMage(Mage mage, Mage mage2)
{
    while (mage.isLive && mage2.isLive)
    {
        mage.Attack(mage2);
    }
}





