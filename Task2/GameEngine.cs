using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class GameEngine
    {
        private Map gameMap;

        public Map mapValue { get { return gameMap; } }

        public GameEngine() 
        {
            gameMap(10, 20, 10, 20, 5);
        }

        public bool MovePlayer() 
        {
            if (true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
