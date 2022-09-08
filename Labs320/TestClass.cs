using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs320
{
    internal class TestClass
    {
        public delegate void HealthChangedDelegate(int healthValue, int maxHealthValue);   
        

        private int _health;

        public TestClass(int health)
        {
            _health = health;
            MaxHealth = health;
        }

        public int MaxHealth { get; set; }

        public int Health
        {
            get { return _health; }
            set 
            {
                _health = value; 

                    HealthChangedEvent?.Invoke(_health, MaxHealth);

            }
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;            
        }


        public event HealthChangedDelegate HealthChangedEvent;
    }
}
