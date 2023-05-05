using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameUnits
{
    public class SettlerUnit : Unit
    {
        public override float Cost
        {
            get { return 5f; }
        }
        public SettlerUnit(int mov=1, int health=2) : base(mov, health)
        {
            movement = mov;
            Health = health;
        }
    }
}