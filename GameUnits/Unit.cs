using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameUnits
{
    public abstract class Unit
    {
        public int movement;
        public virtual int Health { get; set; }
        public abstract float Cost { get; }

        public Unit(int movement, int health)
        {
            this.movement = movement;
            Health = health;
        }

        public void Move()
        {
            Console.WriteLine($"This unit has moved {movement} tiles");
        }
        
        public override string ToString()
        {
            return $"{this.GetType().Name}: HP={this.Health} COST={this.Cost}";
        }
    }
}