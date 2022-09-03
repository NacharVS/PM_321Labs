/*var a = new Mage();
var b = new Mage();
a.AttackFireBoal(b);
a.Attack(b);
a.Attack(b);
a.TargetHeal(b);*/

var a = new Footmen(100, 30, 150, 100, 20, "Footman");
var b = new Mage(100, 30, 150, 150, 30, "Mag");
b.AttackFireBoal(a);
b.Attack(a);
b.AttackFireBoal(a);

a.Attack(b);
a.Attack(b);

b.TargetHeal(a);
b.TargetHeal(a);

b.AttackFireBoal(a);
b.AttackFireBoal(a);

a.getInfo();