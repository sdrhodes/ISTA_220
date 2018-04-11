using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Infantryman : Personnel, IPresentForInspection
    {
        
        public override void Train(string a)
        {
            Console.WriteLine($"The {a} clears the room.");
        }
   
        public override void PerformMission(string a)
        {
            Console.WriteLine($"The {a} takes the hill.");
        }

        public void PresentForInspection()
        {
            AutomaticRifleWeapon automaticRifleWeapon = new AutomaticRifleWeapon();
            Console.WriteLine($"Your weapon is a {automaticRifleWeapon.weaponName}");
            Console.WriteLine($"Your weapon is {automaticRifleWeapon.weaponType} type");
            Console.WriteLine($"Your weapon uses {automaticRifleWeapon.weaponAmmo}");
            Console.WriteLine($"Your weapon's fire rate is {automaticRifleWeapon.weaponFireRate}");
            Console.WriteLine($"Your weapon damage is {automaticRifleWeapon.weaponDamage}");
        }
    }

}
