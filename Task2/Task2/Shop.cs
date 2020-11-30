using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Shop
    {
        private Weapon[] stock = new Weapon[3];
        private Random r = new Random();
        private Character player1 = new Character();

        public Shop()
        {

        }

        private Weapon RandomWeapon()
        {
            int weapontype = r.Next(0, 4 + 1);
            switch (weapontype)
            {
                case 0:
                    MeleeWeapon dagger = new MeleeWeapon();
                    return MeleeWeapon.dagger();
                    break;
                case 1:
                    MeleeWeapon longsword = new MeleeWeapon();
                    return MeleeWeapon.longsword();
                    break;
                case 2:
                    RangedWeapon rifle = new RangedWeapon();
                    return RangedWeapon.rifle();
                    break;
                case 3:
                    RangedWeapon longbow = new RangedWeapon();
                    return RangedWeapon.longbow();
                    break;
            }
        }

        public bool canBuy(int num)
        {
            if (player1.goldValue >= MeleeWeapon.costValue())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Buy(int num) 
        {
            player1.goldValue =- stock.costValue;
            player1.Pickup();
            RandomWeapon();
        }

        public string DisplayWeapon(int num) 
        {
            
        }

    }
}
