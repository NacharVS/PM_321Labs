using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs320.IntefacesLab
{
    internal interface IWeapon
    {
        public int Damage { get; }
        public string Name { get; }

        public void SingleShoot();

        public void ShowInfo();
    }
}
