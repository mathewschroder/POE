using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    abstract class Weapon : Item
    {
        protected int damage;
        protected int range;
        protected int durability;
        protected int cost;
        protected string weaponType;
        Random r = new Random();
        public int damageValue
        {
            get { return damage; }
            set { damage = damageValue; }
        }
        public int rangeValue
        {
            get { return range; }
            set { range = rangeValue; }
        }
        public int durabilityValue
        {
            get { return durability; }
            set { durability = durabilityValue; }
        }
        public int costValue
        {
            get { return cost; }
            set { cost = costValue; }
        }

        public string weaponTypeValue 
        {
            get { return weaponType; }
            set { weaponType = weaponTypeValue; }
        }


        public Weapon (int xValue, int yValue, int damageValue, int rangeValue, int durabilityValue, int costValue, string weaponTypeValue) :base (xValue, yValue) 
        {
            this.xValue = r.Next(1, Map.getXAxisValue());
            this.yValue = r.Next(1, Map.getYAxisValue());
            Map.MapValue[this.yValue, this.xValue] = TileType.Weapon();
        }
    }
}
