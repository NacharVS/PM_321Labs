using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWorkLK_W3LG_
{
    internal class Weapon : Equipment
    {
        public static List<Weapon> _weaponList = new List<Weapon>();

        public static int damage = 20;
        public int Damage { get; set; }
        public Weapon(int damage, string name)
        {
            this.Damage = damage;
            this.Name = name;
            _weaponList.Add(this);
        }

    }
}
