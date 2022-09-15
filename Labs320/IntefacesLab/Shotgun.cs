using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs320.IntefacesLab
{
    internal class Shotgun : IWeapon
    {
        public int Damage => 50;
        public string Name => "Shotgun";
        public void ShowInfo()
        {
            Console.WriteLine($"Weapon - {Name} Damage - {Damage}");
        }

        public void SingleShoot()
        {
            Console.WriteLine("BLAM!");
        }
    }
}
