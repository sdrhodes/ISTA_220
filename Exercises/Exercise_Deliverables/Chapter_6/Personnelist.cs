using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Personnelist : Personnel, IPresentForInspection
    {
        
        public override void Train(string a)
        {
            Console.WriteLine($"The {a} sits at the desk.");
        }

        public override void PerformMission(string a)
        {
            Console.WriteLine($"The {a} kills trees.");
        }

        public void PresentForInspection()
        {
            PistolWeapon pistol = new PistolWeapon();
            Console.WriteLine($"Your weapon is a {pistol.weaponName}");
            Console.WriteLine($"Your weapon is {pistol.weaponType} type");
            Console.WriteLine($"Your weapon uses {pistol.weaponAmmo}");
            Console.WriteLine($"Your weapon's fire rate is {pistol.weaponFireRate}");
            Console.WriteLine($"Your weapon damage is {pistol.weaponDamage}");
        }
    }

}

