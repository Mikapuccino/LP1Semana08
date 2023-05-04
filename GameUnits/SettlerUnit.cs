using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameUnits
{
    public class SettlerUnit : Unit
    {
        public SettlerUnit( int movement, int health)
        {
            this.movement = 1;
            Health = 2;
        }
    }
}