using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Personnelist : Personnel
    {
        
        public override void Train(string a)
        {
            Console.WriteLine($"The {a} sits at the desk.");
        }

        public override void PerformMission(string a)
        {
            Console.WriteLine($"The {a} kills trees.");
        }

    }

}

