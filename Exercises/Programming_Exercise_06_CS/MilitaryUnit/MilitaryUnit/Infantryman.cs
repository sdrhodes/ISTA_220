using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Infantryman : Personnel, IPresentWeapon
    {
        
        public override void Train(string a)
        {
            Console.WriteLine($"The {a} clears the room.");
        }
   
        public override void PerformMission(string a)
        {
            Console.WriteLine($"The {a} takes the hill.");
        }

        public void PresentWeapon()
        {
            MachineGunWeapon machineGunWeapon = new MachineGunWeapon();
            Console.WriteLine($"Your weapon is a {machineGunWeapon.weaponName}");
            Console.WriteLine($"Your weapon is {machineGunWeapon.weaponType} type");
            Console.WriteLine($"Your weapon uses {machineGunWeapon.weaponAmmo}");
            Console.WriteLine($"Your weapon's fire rate is {machineGunWeapon.weaponFireRate}");
            Console.WriteLine($"Your weapon damage is {machineGunWeapon.weaponDamage}");
        }
    }

}
