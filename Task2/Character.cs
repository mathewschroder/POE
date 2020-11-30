using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Task2
{
    public abstract class Character : Tile
    {
        protected int damage;
        protected int hp;
        protected int maxHp;
        protected Tile[] Vision = new Tile[8];
        protected int gold;

        public enum movement { Up, Down, Left, Right, None };

        public int damageValue { get { return damage; } set { damage = value; } }
        public int hpValue { get { return hp; } set { hp = value; } }
        public int maxHpValue { get { return maxHp; } set { maxHp = value; } }
        public int goldValue { get {return gold } set { gold = value; } }

        public Character(int xValue, int yValue, int damageValue, int hpValue, int maxHpValue, int goldValue) : base(xValue, yValue, TileType.None)
        {
            this.xValue = xAxis;
            this.yValue = yAxis;
            this.damageValue = damage;
            this.hpValue = hp;
            this.maxHpValue = maxHp;
            this.goldValue = gold;
        }

        public virtual void Attack(int target) 
        {
            target -= damage;
        }

        public bool isdead(int targetHp) 
        {
            if (targetHp <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public virtual bool CheckRange() 
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

        private int DistanceTo(Tile target, Tile attacker) 
        {
            int distance = target.xValue - attacker.xValue;
            distance += (target.yValue - attacker.yValue);
            return distance;
        }

        public void Move()
        {
            switch (movement)
            {
                case movement.Up:
                    yAxis -= 1;
                    break;
                case movement.Down:
                    yAxis += 1;
                    break;
                case movement.Left:
                    xAxis -= 1;
                    break;
                case movement.Right:
                    xAxis += 1;
                    break;
                case movement.None:
                    break;
                default:
                    break;
            }
        }

        public virtual void returnMove() 
        {
            
        }

        public void Pickup(Item i) 
        {
            bool isGold = false;
            if (isGold)
            {
                gold++;
            }
        }

         public abstract override string ToString(); 
        
    }
}
