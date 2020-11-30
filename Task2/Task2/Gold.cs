using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    internal class Gold : Item
    {
        private int goldAmount;
        private Random r = new Random();
        public int goldAmountValue
        {
            get { return goldAmount; }
            set { goldAmount = goldAmountValue; }
        }
        public Gold(int xValue,int yValue, int goldAmountValue) : base(xValue, yValue) 
        {
            this.xValue = xAxis;
            this.yValue = yAxis;
            this.goldAmountValue = r.Next(1, 5 + 1);
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
