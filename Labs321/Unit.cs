using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs321
{
    internal class Unit
    {
        public Unit(int health, string name)
        {
            Health = health;
            Name = name;
        }

        public int Health { get; set; }
        public string Name { get; set; }    
                        

    }
}
