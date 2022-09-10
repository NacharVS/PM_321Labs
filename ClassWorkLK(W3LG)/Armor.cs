using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ClassWorkLK_W3LG_
{
    internal class Armor : Equipment
    {
        public int Defense { get; set; }
        public Armor (int defense, string name)
        {
            this.Defense = defense;
            this.Name = name;           
        }
    }  
}
