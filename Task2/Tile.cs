using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    public abstract class Tile
    {
        protected int xAxis;
        protected int yAxis;

        public int xValue { get { return xAxis; } set { xAxis = value; } }
        public int yValue { get { return yAxis; } set { yAxis = value; } }
        protected TileType thisType;
       
        public enum TileType { Hero, Enemy, Gold, Weapon, Obstacle, None }

        public Tile(int xValue, int yValue, TileType tileType) 
        {
            this.xAxis = xValue;
            this.yAxis = yValue;
            this.thisType = tileType;
        }

    }
}
