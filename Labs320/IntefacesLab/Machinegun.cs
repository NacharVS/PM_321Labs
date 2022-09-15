using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs320.IntefacesLab
{
    internal class Machinegun : IWeapon, IAutomaticWeapon
    {
        public int Damage => 30;
        public string Name => "AK-74";

        public void MultiShoot()
        {
            Console.WriteLine("piu-piu-piu");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Weapon - {Name} Damage - {Damage}"  );
        }

        public void SingleShoot()
        {
            Console.WriteLine("piu!");
        }
    }
}
