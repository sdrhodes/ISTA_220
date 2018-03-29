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
        void GetInfo()
        {
            Console.WriteLine("What is your name, soldier?");
            name = Console.ReadLine();
            Console.WriteLine("What is your rank?");
            rank = Console.ReadLine();
        }
        public abstract void PerformMission(string a);
        void Sleep()
        {
            Console.WriteLine($"{rank} {name} sleeps.");
        }
        void Eat()
        {
            Console.WriteLine($"{name} eats.");
        }
        
    }
}
