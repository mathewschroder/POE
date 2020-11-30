using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace Task2
{
    class Obstacle : Tile
    {
        public Obstacle(int xValue, int yValue, TileType thisType) : base(xValue , yValue, TileType.Obstacle) 
        {
            this.xValue = xAxis;
            this.yValue = yAxis;
        }
           
    }
}
