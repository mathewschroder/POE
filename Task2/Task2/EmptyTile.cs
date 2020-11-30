using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Text;
using System.Transactions;
using System.Xml.Schema;

namespace Task2
{
    class EmptyTile : Tile
    {
        public EmptyTile(int xValue, int yValue) : base(xValue, yValue, TileType.None)
        {
            this.xValue = xAxis;
            this.yValue = yAxis;
        }


    }
}
