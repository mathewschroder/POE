using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace Task2
{
    internal class Goblin : Enemy
    {
        public Goblin(int xValue, int yValue, int damageValue, int hpValue, int maxHpValue) : base(xValue, yValue, damageValue, hpValue, maxHpValue)
        {
            this.xValue = xAxis;
            this.yValue = yAxis;
            this.damageValue = 1;
            this.hpValue = 10;
            this.maxHpValue = 10;
        }

        public override void returnMove()
        {
            base.returnMove();
        }
    }
}
