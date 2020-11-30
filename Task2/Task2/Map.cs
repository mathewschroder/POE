using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Map
    {
        private Tile[,] Map;
        private Hero Player = new Hero();
        private int NumEnemies;
        private Enemy[] enemies;
        private int xAxis, yAxis, xMin, xMax, yMin, yMax;
        Random r = new Random();

        public Tile mapValue { get { return Map[,]; } set { Map[,] = mapValue[,]; } }
        public Hero playerValue { get { return Player[]; } set { Player[] = playerValue[]; } }
        public int numEnemiesValue { get { return NumEnemies; } set { NumEnemies = numEnemiesValue; } }
        // insert Enmey array accessor
        public int xAxisValue { get { return xAxis; } set { xAxis = xAxisValue; } }
        public int yAxisValue { get { return yAxis; } set { yAxis = yAxisValue; } }
        public int xMinValue { get { return xMin; } set { xMin = xMinValue; } }
        public int xMaxValue { get { return xMax; } set { xMax = xMaxValue; } }
        public int yMinValue { get { return yMin; } set { yMin = yMinValue; } }
        public int yMaxValue { get { return yMax; } set { yMax = yMaxValue; } }

        public Map(int xMinValue, int xMaxValue, int yMinValue, int yMaxValue, int numEnemiesValue)
        {

            this.xMin = xMinValue;
            this.xMax = xMaxValue;
            this.yMin = yMinValue;
            this.yMax = yMaxValue;

            this.xAxis = r.Next(xMinValue, xMaxValue + 1);
            this.yAxis = r.Next(yMinValue, yMaxValue + 1);

            this.NumEnemies = numEnemiesValue;

            Tile[,] mapValue = new Tile[yAxis, xAxis];
        }

        public void UpdateVision() 
        { 
            
        }

        private Tile Create() 
        {
            
        }

        public Item GetItemAtPostion(int x , int y) 
        {
            if (Map[y,x] == 1)
            {
                
            }
            else
            {

            }
        }

    }
}
