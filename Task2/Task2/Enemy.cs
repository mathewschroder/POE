using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    public abstract class Enemy : Character
    {
        protected Random r = new Random();

        public Enemy(int xValue, int yValue, int damageValue, int hpValue, int maxHpValue) : base(xValue, yValue, damageValue, hpValue, maxHpValue)
        {
            this.xValue = xAxis;
            this.yValue = yAxis;
            this.damageValue = damage;
            this.hpValue = hp;
            this.maxHpValue = maxHp;
        }

        public override string ToString()
        {
            return "[" + xAxis + ", " + yAxis + "] " + damage;
        }
    }
}
