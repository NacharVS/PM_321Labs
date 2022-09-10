using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWorkLK_W3LG_
{
     internal class Archer : Unit
    {
        public static int health = 350;
        public static int damage = 20;
        public static int defense = 5;
        public Quiver Quiver;
        public Archer() : base(health, damage, defense, "Archer") 
        {
            this.Weapon = new Bow();
            this.Quiver = new Quiver();
            this.BaseDamage += Weapon.Damage;
            this.Damage += Weapon.Damage;

        }
        public override void Attack(Unit unit)
        {
            if (this.Quiver.arrows > 0)
            {
                this.Quiver.arrows -= 1;
                base.Attack(unit);    
            }
            else
            {
                Console.WriteLine("Run out of arrows");
            }
 
        }
    }
}
