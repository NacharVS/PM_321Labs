using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warcraft
{
    class Program
    {
        static void Main()
        {
            Unit Oleg = new Footman();
            Unit Alex = new Mage();
            Unit Akakiy = new Footman();

            /*Oleg.Attack(Akakiy);
            Akakiy.Attack(Oleg);
            ((Mage) Alex).TargetHeal(Oleg);*/

            while (Oleg.Health > 0 && Alex.Health > 0)
            {
                Oleg.Attack(Alex);
                Alex.Attack(Oleg);
            }
        }
    }
}
