using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    internal class Leader : Enemy
    {
        private Tile target = new Tile();

        public Leader(int xValue, int yValue, int damageValue, int hpValue, int maxHpValue) : base(xValue, yValue, damageValue, hpValue, maxHpValue) 
        {
            this.damageValue = 2;
            this.hpValue = 20;
            this.maxHpValue = 20;
        }

        public override void returnMove()
        {
            base.returnMove();
        }
    }
}
