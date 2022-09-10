using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWorkLK_W3LG_
{
    internal class Quiver : Equipment
    {
        public static int arrowsCount = 30;
        public int arrows { get; set; }
        public string name { get; set; }

        public Quiver (string name)
        {
            this.name = name;
            this.arrows = arrowsCount;
        }

        public Quiver()
        {
            this.name = "Quiver";
            this.arrows = arrowsCount;
        }
    }
}
