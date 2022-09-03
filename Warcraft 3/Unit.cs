using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warcraft_3
{
    internal class Unit
    {
        public int Health;
        int MoveSpeed;
        int Cost;
        public int Damage;
        

        public Unit (int Health, int MoveSpeed, int Cost, int Damage)
        {
            this.Health = Health;
            this.MoveSpeed = MoveSpeed;
            this.Cost = Cost;
            this.Damage = Damage;
        }

        public void Move()
        {

        }

        public void Attack()
        {

        }
    }
}
