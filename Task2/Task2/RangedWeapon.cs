using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    internal class RangedWeapon : Weapon
    {
        public enum Types { Rifle, Longbow }

        public override Range()
        {
            return base.range();
        }

        public RangedWeapon(int xValue, int yValue, int damageValue, int rangeValue, int durabilityValue, int costValue, string weaponTypeValue) : base(xValue, yValue, damageValue, rangeValue, durabilityValue, costValue, weaponTypeValue)
        {
            switch (Types)
            {
                case Types.Rifle:
                    this.weaponTypeValue = "Rifle";
                    this.durabilityValue = 3;
                    this.rangeValue = 3;
                    this.damageValue = 5;
                    this.costValue = 7;
                    break;
                case Types.Longbow:
                    this.weaponTypeValue = "Longbow";
                    this.durabilityValue = 4;
                    this.rangeValue = 2;
                    this.damageValue = 4;
                    this.costValue = 6;
                    break;
            }
        }
    }
}
