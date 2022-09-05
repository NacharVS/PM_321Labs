using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Archer : Unit
{
    protected int arrowCount;
    public int range;

    public Archer(int health, int walkingSpeed, int cost, int damage, string name, int arrowCount, int range) : base(health, walkingSpeed, cost, damage, name)
    {
        this.arrowCount = arrowCount;
        this.range = range;
    }

    public Archer() : base(80, 40, 100, 20, "Archer")
    {
        arrowCount = 15;
        range = 25;
    }

    public override void Attack(Unit unit)
    {
        arrowCount--;
        base.Attack(unit);
    }

    public override void Attack(Footman footmen)
    {
        arrowCount--;
        base.Attack(footmen);
    }

    public override void getInfo()
    {
        base.getInfo();
        Console.WriteLine($"Number of arrows - {arrowCount} \n" +
                          $"Range - {range}");
    }
}
