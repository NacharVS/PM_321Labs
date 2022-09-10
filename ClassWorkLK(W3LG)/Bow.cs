using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWorkLK_W3LG_
{
    internal class Bow : Weapon
    {
        public static int damage = 20;
        public Bow() : base(damage, "Bow")
        {

        }
    }
}
