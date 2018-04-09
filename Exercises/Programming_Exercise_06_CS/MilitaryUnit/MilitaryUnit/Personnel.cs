using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    abstract class Personnel
    {
        private string name = null;
        private string rank = null;
        public abstract void Train(string a);
        private string[] SoldierName = { "Matt", "Donovan", "Norma", "Ryan",
            "Rory", "Ricardo", "Steven", "Thomas",
            "Oscar", "Sam", "Dominique", "Deniqtrius", "Justin", "Nick" };
        private string[] SoldierRank = { "Private", "Corporal", "Sergeant",
            "Lieutenant", "Captain", "Major" };

        public void GetInfo()
        {
            Random r = new Random();
            int rName = r.Next(0, SoldierName.Length-1);
            Console.WriteLine("What is your name, soldier?");
            name = SoldierName.ElementAt(rName);
            Console.WriteLine($"My name is {name}, General");
            Random s = new Random();
            int sRank = s.Next(0, SoldierRank.Length - 1);
            Console.WriteLine("What is your rank?");
            rank = SoldierRank.ElementAt(sRank);
            Console.WriteLine($"My rank is {rank}, General");
            Console.WriteLine("\r\nWould you like to meet more troops? Y/N");
            char answer = char.Parse(Console.ReadLine());
            if (answer == 'y' || answer == 'Y')
            {
                GetInfo();
            }
            else if (answer == 'n' || answer == 'N')
            {
                return;
            }
            else
            {
                Console.WriteLine("Please enter Y/N.");
                GetInfo();
            }
        }
        public abstract void PerformMission(string a);
        public void Sleep()
        {
            Console.WriteLine($"{rank} {name} sleeps.");
        }
        public void Eat()
        {
            Console.WriteLine($"{rank} {name} goes to the chow hall.");
        }
        
    }
}
