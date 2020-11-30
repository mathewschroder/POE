using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace Task2
{
   public abstract class Item : Tile
    {
        public Item(int xValue, int yValue) : base(xValue, yValue, TileType.None) 
        {
            this.xValue = xAxis;
            this.yValue = yAxis;
        }
        public abstract override string ToString();
    }
}
