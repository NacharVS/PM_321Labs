using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace warcraft
{
    class Archer : Unit
    {
        public static List<Archer> Archers = new List<Archer>();

        public const int Health = 55;
        private const int WalkedSpeed = 35;
        private const int Cost = 225;
        private const int Damage = 12;
        private const int ArrowCount = 5;

        public int arrowCount = ArrowCount + BlackSmith.upgradeBow;

        public Archer() : base(Health, WalkedSpeed, Cost, Damage)
        {
            if (resource < Cost)
            {
                Console.WriteLine("Не хватило денег");
                this.isLive = false;
            }
            else
            {
                resource -= Cost;
                Archers.Add(this);
            }
        }

        public override void Attack(Unit attackedPlayer)
        {
            if (this.arrowCount > 0 && this.isLive && attackedPlayer.isLive)
            {
                --this.arrowCount;
                base.Attack(attackedPlayer);
            }
            else if (this.arrowCount == 0 && this.isLive && attackedPlayer.isLive)
            {
                Console.WriteLine("Стрелы кончились");
            }
        }

        public override void Attack(Footman attackedPlayer)
        {
            if (this.arrowCount > 0 && this.isLive && attackedPlayer.isLive)
            {
                --this.arrowCount;
                base.Attack(attackedPlayer);
            }
            else if (this.arrowCount == 0 && this.isLive && attackedPlayer.isLive)
            {
                Console.WriteLine("Стрелы кончились");
            }
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"arrow count: {this.arrowCount}");
        }
    }
}
