using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace warcraft
{
    class Mage : Unit
    {
        private const int Health = 50;
        private const int WalkedSpeed = 35;
        private const int Cost = 300;
        private const int Damage = 15;
        private const int Mane = 100;

        public delegate void GetHealDelegate(int Damage);
        public event GetHealDelegate GetHealEvents;

        int mane = Mane;
        public Mage() : base(Health, WalkedSpeed, Cost, Damage)
        {
            if (resource < Cost)
            {
                Console.WriteLine("Не хватило денег");
                this.isLive = false;
            }
            else
            {
                resource -= Cost;
                GetHealEvents += Heal;
            }
        }

        static void Heal(int heal)
        {
            Console.WriteLine($"Восстановлено хп - {heal}");
        }

        public void CastFireBall(Unit attackedPlayer)
        {
            if (this.mane >= 20 && attackedPlayer.isLive && this.isLive)
            {
                this.mane -= 20;
                this.damage *= 2;
                base.Attack(attackedPlayer);
                this.damage = Mage.Damage;
            }
        }

        public void CastFireBall(Footman attackedPlayer)
        {
            if (this.mane >= 20 && attackedPlayer.isLive && this.isLive)
            {
                this.mane -= 20;
                this.damage *= 2;
                base.Attack(attackedPlayer);
                this.damage = Mage.Damage;
            }
        }

        public void TargetHeal(Mage healedPlayer)
        {
            if (healedPlayer.isLive && this.isLive)
            {
                if (this.mane >= 15 && Mage.Health >= healedPlayer.health + 15)
                {
                    this.mane -= 15;
                    healedPlayer.health += 15;
                    GetHealEvents?.Invoke(15);
                }
                else if (this.mane >= 15 && Mage.Health < healedPlayer.health + 15)
                {
                    this.mane -= Mage.Health - healedPlayer.health;
                    GetHealEvents?.Invoke(Mage.Health - healedPlayer.health);
                    healedPlayer.health = Mage.Health;
                }
                else if (this.mane < 15 && Mage.Health >= healedPlayer.health + this.mane)
                {
                    healedPlayer.health += this.mane;
                    GetHealEvents?.Invoke(this.mane);
                    this.mane = 0;
                }
                else if (this.mane < 15 && Mage.Health < healedPlayer.health + this.mane)
                {
                    this.mane -= Mage.Health - healedPlayer.health;
                    GetHealEvents?.Invoke(Mage.Health - healedPlayer.health);
                    healedPlayer.health = Mage.Health;
                }
                Console.WriteLine($"лечущий - Mage");
                this.GetInfo();
                Console.WriteLine($"лечимый - Mage");
                healedPlayer.GetInfo();
            }
        }
        public void TargetHeal(Footman healedPlayer)
        {
            if (healedPlayer.isLive && this.isLive)
            {
                if (this.mane >= 15 && Footman.Health >= healedPlayer.health + 15)
                {
                    this.mane -= 15;
                    healedPlayer.health += 15;
                    GetHealEvents?.Invoke(15);
                    healedPlayer.Rage();
                }
                else if (this.mane >= 15 && Footman.Health < healedPlayer.health + 15)
                {
                    this.mane -= Footman.Health - healedPlayer.health;
                    GetHealEvents?.Invoke(Footman.Health - healedPlayer.health);
                    healedPlayer.health = Footman.Health;
                    healedPlayer.Rage();
                }
                else if (this.mane < 15 && Footman.Health >= healedPlayer.health + this.mane)
                {
                    healedPlayer.health += this.mane;
                    GetHealEvents?.Invoke(this.mane);
                    this.mane = 0;
                    healedPlayer.Rage();
                }
                else if (this.mane < 15 && Footman.Health < healedPlayer.health + this.mane)
                {
                    this.mane -= Footman.Health - healedPlayer.health;
                    GetHealEvents?.Invoke(Footman.Health - healedPlayer.health);
                    healedPlayer.health = Footman.Health;
                    healedPlayer.Rage();
                }
                Console.WriteLine($"лечущий - Mage");
                this.GetInfo();
                Console.WriteLine($"лечимый - Footman");
                healedPlayer.GetInfo();
            }
        }
        public void TargetHeal(Pessant healedPlayer)
        {
            if (healedPlayer.isLive && this.isLive)
            {
                if (this.mane >= 15 && Pessant.Health >= healedPlayer.health + 15)
                {
                    this.mane -= 15;
                    healedPlayer.health += 15;
                    GetHealEvents?.Invoke(15);
                }
                else if (this.mane >= 15 && Pessant.Health < healedPlayer.health + 15)
                {
                    this.mane -= Pessant.Health - healedPlayer.health;
                    GetHealEvents?.Invoke(Pessant.Health - healedPlayer.health);
                    healedPlayer.health = Pessant.Health;
                }
                else if (this.mane < 15 && Pessant.Health >= healedPlayer.health + this.mane)
                {
                    healedPlayer.health += this.mane;
                    GetHealEvents?.Invoke(this.mane);
                    this.mane = 0;
                }
                else if (this.mane < 15 && Pessant.Health < healedPlayer.health + this.mane)
                {
                    this.mane -= Pessant.Health - healedPlayer.health;
                    GetHealEvents?.Invoke(Pessant.Health - healedPlayer.health);
                    healedPlayer.health = Pessant.Health;
                }
                Console.WriteLine($"лечущий - Mage");
                this.GetInfo();
                Console.WriteLine($"лечимый - Pessant");
                healedPlayer.GetInfo();
            }
        }

        public void TargetHeal(Archer healedPlayer)
        {
            if (healedPlayer.isLive && this.isLive)
            {
                if (this.mane >= 15 && Archer.Health >= healedPlayer.health + 15)
                {
                    this.mane -= 15;
                    healedPlayer.health += 15;
                    GetHealEvents?.Invoke(15);
                }
                else if (this.mane >= 15 && Archer.Health < healedPlayer.health + 15)
                {
                    this.mane -= Archer.Health - healedPlayer.health;
                    GetHealEvents?.Invoke(Archer.Health - healedPlayer.health);
                    healedPlayer.health = Archer.Health;
                }
                else if (this.mane < 15 && Archer.Health >= healedPlayer.health + this.mane)
                {
                    healedPlayer.health += this.mane;
                    GetHealEvents?.Invoke(this.mane);
                    this.mane = 0;
                }
                else if (this.mane < 15 && Archer.Health < healedPlayer.health + this.mane)
                {
                    this.mane = Archer.Health - healedPlayer.health;
                    GetHealEvents?.Invoke(Archer.Health - healedPlayer.health);
                    healedPlayer.health = Archer.Health;
                }
                Console.WriteLine($"лечущий - Mage");
                this.GetInfo();
                Console.WriteLine($"лечимый - Pessant");
                healedPlayer.GetInfo();
            }
        }

        public override void Attack(Unit attackedPlayer)
        {
            if (this.mane >= 10 && this.isLive)
            {
                this.mane -= 10;
                base.Attack(attackedPlayer);
            }
        }

        public override void Attack(Footman attackedPlayer)
        {
            if (this.mane >= 10 && this.isLive)
            {
                this.mane -= 10;
                base.Attack(attackedPlayer);
            }
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"mane: {this.mane}");
        }
    }
}
