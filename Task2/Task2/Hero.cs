using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    internal class Hero : Character
    {
        public Hero(int xValue, int yValue, int damageValue, int hpValue, int maxHpValue, int goldValue) : base(xValue, yValue, damageValue, hpValue, maxHpValue, goldValue) 
        {
            this.xValue = xAxis;
            this.yValue = yAxis;
            this.damageValue = 2;
            this.hpValue = hp;
            this.maxHpValue = maxHp;
            this.goldValue = gold;
        }

        public override string ToString()
        {
            return "Player stats: " + "\n" +
                "HP: " + hp + "/" + maxHp + "\n" +
                "Damage: " + damage + "\n" +
                "[" + xAxis + "," + yAxis + "]" + "\n" +
                "Gold Amount: " + gold;
        }

        public override void returnMove()
        {
            base.returnMove();

        }
    }
}
