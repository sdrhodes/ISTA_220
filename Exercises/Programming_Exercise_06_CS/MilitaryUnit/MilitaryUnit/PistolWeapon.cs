using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class PistolWeapon : Weapons
    {
        public PistolWeapon()
        {
            this.WeaponAmmo = "9 mm";
            this.WeaponFireRate = "Semi-auto";
            this.WeaponDamage = "Low";
            this.WeaponName = "M9";
            this.WeaponType = "Pistol";
        }
    }
}
