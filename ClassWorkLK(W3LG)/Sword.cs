using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWorkLK_W3LG_
{
    internal class Sword : Weapon 
    {
        public static int damage = 20;
        public Sword() : base(damage, "Sword")
        {

        }        
    }
}
