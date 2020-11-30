using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    internal class Mage : Enemy
    {
        public Mage(int xValue, int yValue, int damageValue, int hpValue, int maxHpValue) : base(xValue, yValue, damageValue, hpValue, maxHpValue) 
        {
            this.xValue = xAxis;
            this.yValue = yAxis;
            this.damageValue = 5;
            this.hpValue = 5;
        }

        public override void returnMove()
        {
            base.returnMove();
            int movemnet = 0;
        }
    }
}
