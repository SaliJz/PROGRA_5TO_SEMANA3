using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turn_Based_Game
{
    public interface ICombatant
    {
        void TakeDamage(int damage);
        int GetDamage();
        bool IsAlive();
    }
}