using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turn_Based_Game
{
    public abstract class Character : ICombatant
    {
        public int Health { get; protected set; }
        public int Damage { get; protected set; }

        protected Character(int health, int damage)
        {
            if (health <= 0 || health > 100)
            {
                throw new ArgumentException("La vida debe ser mayor que 0 y no superar 100.");
            }

            if (damage < 0 || damage > 100)
            {
                throw new ArgumentException("El daño debe estar entre 0 y 100.");
            }

            Health = health;
            Damage = damage;
        }

        public virtual void TakeDamage(int damage)
        {
            if (damage < 0)
            {
                throw new ArgumentException("El daño no puede ser negativo.");
            }

            Health -= damage;

            if (Health < 0) Health = 0;
        }

        public virtual int GetDamage()
        {
            return Damage;
        }

        public virtual bool IsAlive()
        {
            return Health > 0;
        }
    }
}