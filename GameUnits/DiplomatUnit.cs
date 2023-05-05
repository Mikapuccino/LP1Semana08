using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameUnits
{
    public class DiplomatUnit : XPUnit
    {
        public override float Cost
        {
            get { return 7.1f; }
        }

        public DiplomatUnit(int mov=6, int health=1) : base(mov, health)
        {
            movement = mov;
            Health = health;
        }

        public void MakeAgreement(Unit unit)
        {
            if (unit is DiplomatUnit)
            {
                XP += 3;
            }

            else if (unit is SettlerUnit)
            {
                XP += 2;
            }
            
            else
            {
                XP += 1;
            }
        }
    }
}