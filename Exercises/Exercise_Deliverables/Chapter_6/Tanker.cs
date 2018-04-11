using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Tanker : Personnel, IPresentForInspection
    { 
        public override void Train(string a)
        {
            Console.WriteLine($"The {a} fires a cannon.");
        }

        public override void PerformMission(string a)
        {
            Console.WriteLine($"The {a} provides fire.");
        }

       
        public void PresentForInspection()
        {
            AutomaticRifleWeapon machineGunWeapon = new AutomaticRifleWeapon();
            Console.WriteLine($"Your weapon is a {machineGunWeapon.weaponName}");
            Console.WriteLine($"Your weapon is {machineGunWeapon.weaponType} type");
            Console.WriteLine($"Your weapon uses {machineGunWeapon.weaponAmmo}");
            Console.WriteLine($"Your weapon's fire rate is {machineGunWeapon.weaponFireRate}");
            Console.WriteLine($"Your weapon damage is {machineGunWeapon.weaponDamage}");
        }
        
    }
}
