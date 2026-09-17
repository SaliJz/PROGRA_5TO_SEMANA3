using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turn_Based_Game
{
    public abstract class Enemy : Character
    {
        public string Name { get; }
        public Enemy(int health, int damage, string name) : base(health, damage)
        {
            Name = name;
        }
    }
}
