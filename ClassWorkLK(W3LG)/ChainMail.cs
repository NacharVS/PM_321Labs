using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ClassWorkLK_W3LG_
{
    internal class ChainMail : Armor
    {
        public static int defense = 40;
        public ChainMail() : base(defense, "ChainMail")
        {

        }
    }
}
        
   