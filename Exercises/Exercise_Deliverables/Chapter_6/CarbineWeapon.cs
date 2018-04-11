using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class CarbineWeapon:Weapons
    {
        public CarbineWeapon()
        {
            this.WeaponAmmo = "5.56";
            this.WeaponFireRate = "900 RPM";
            this.WeaponDamage = "Medium";
            this.WeaponName = "M4";
            this.WeaponType = "Carbine";
        }
    }
}
