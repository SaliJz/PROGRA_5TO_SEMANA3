using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class EnemyRange : Enemy, IShooter
    {
        private int munitions;
        public EnemyRange(int life, int damage) : base(life, damage)
        {
            this.munitions = 10; 
        }

        public int Shoot()
        {
            if (munitions > 0)
            {
                munitions--;
                return GetDamage();
            }
            return 0;
        }

        public override int GetDamage()
        {
            return damage;
        }
    }
}
