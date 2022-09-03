using warcraft;

Mage mage = new Mage();
Mage mage2 = new Mage();
Footman footman = new Footman();
Pessant pessant = new Pessant();
Pessant pessant2 = new Pessant();
Pessant pessant3 = new Pessant();

pessant.Mining();
pessant2.Mining();


mage.CastFireBall(footman);
mage.CastFireBall(mage2);
mage.Attack(footman);



