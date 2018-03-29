using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Tanker : Personnel
    { 
        public override void Train(string a)
        {
            Console.WriteLine($"The {a} fires a cannon.");
        }

        public override void PerformMission(string a)
        {
            Console.WriteLine($"The {a} provides fire.");
        }
    }
}
