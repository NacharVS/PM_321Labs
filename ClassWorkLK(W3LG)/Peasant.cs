﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWorkLK_W3LG_
{
    internal class Peasant : Unit
    {
        public static int health = 400;
        public static int damage = 20;
        public static int defense = 5;

        public Peasant () : base(health, damage, defense, "Peasant") { }
    }
}
