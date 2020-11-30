using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;
using System.Xml.Schema;

namespace Task2
{
    internal class MeleeWeapon : Weapon
    {
        public enum Types { Dagger, Longsword }
        Random r = new Random();

        public override Range()
        {
            return 1;
        }

        public MeleeWeapon(int xValue, int yValue, int damageValue, int rangeValue, int durabilityValue, int costValue, string weaponTypeValue) : base(xValue, yValue, damageValue, rangeValue, durabilityValue, costValue, weaponTypeValue)
        {
            int weapontypenum = r.Next(0, 2);
            switch (weapontypenum)
            {
                case 0: 
                    this.weaponTypeValue = "Dagger";
                    this.durabilityValue = 10;
                    this.damageValue = 3;
                    this.cost = 3;
                    break;
                case 1:
                    this.weaponTypeValue = "Longsword";
                    this.durabilityValue = 6;
                    this.damageValue = 4;
                    this.cost = 5;
                    break;
            }
        }
    }
}
