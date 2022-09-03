using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warcraft
{
    abstract class Building
    {
        protected int health;
        protected int cost;
        protected int lvl;

        public Building(int health, int cost, int lvl) 
        { 
            this.health = health;
            this.cost = cost;
            this.lvl = lvl;
        }

        abstract public void Upgrade();
    }
}
