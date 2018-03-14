using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    class Sheep:Animals 
    {
        public Sheep()
        {
            AnimalType = "Sheep";
            AnimalName = "Ewenis";
            AnimalColor = "White";
            AnimalNoise = "Baah";
        }
    }
}
