using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWorkLK_W3LG_
{
    class program
    {
        static void Main(string[] args)
        {
            Mage mage = new Mage();
            Footman footman = new Footman();
            Peasant peasant = new Peasant();
            mage.Attack(footman);
            footman.Attack(peasant);
            footman.Attack(mage);
            footman.Attack(mage);
        }
    }
}