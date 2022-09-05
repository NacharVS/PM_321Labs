using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


abstract class Building
{
    protected int health;
    protected int cost;
    protected int timeSec;
    protected int lvl;
    protected bool isLive;
    protected string name;

    public Building(int health, int cost, int timeSec, string name)
    {
        this.health = health;
        this.cost = cost;
        this.timeSec = timeSec;
        lvl = 1;
        isLive = true;
        this.name = name;
    }

    public virtual void Upgrade()
    {

    }

}

