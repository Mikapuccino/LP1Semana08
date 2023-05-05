using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameUnits
{
    public class MilitaryUnit : XPUnit
    {
        public int AttackPower { get; }
        public override int Health => Health + XP;
        public override float Cost
        {
            get { return AttackPower + XP; }
        }

        public MilitaryUnit(int mov, int health, int attackPower) :
        base(mov, health)
        {
            AttackPower = attackPower;
        }

        public void Attack(Unit u)
        {
            XP =+ 1;
            u.Health =- 1;
        }

        public override string ToString()
        {
            return base.ToString() + $" AP={AttackPower}";
        }
    }
}