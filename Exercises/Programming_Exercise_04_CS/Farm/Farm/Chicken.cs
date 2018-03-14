using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    class Chicken : Animals
    {
        public Chicken()
        {
            AnimalType = "Chicken";
            AnimalName = "Peck";
            AnimalColor = "Red";
            AnimalNoise = "Cluck";
        }
    }
}
