﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class MachineGunWeapon : Weapons
    {
        public MachineGunWeapon()
        {
            this.WeaponAmmo = "5.56";
            this.WeaponFireRate = "625 RPM";
            this.WeaponDamage = "Medium";
            this.WeaponName = "SCAR";
            this.WeaponType = "Rifle";
        }       
    }
}