using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    class Cow : Animals
    {
        public Cow()
        {
            AnimalType = "Cow";
            AnimalName = "Wilma";
            AnimalColor = "Light brown";
            AnimalNoise = "Moo";
        }
    }
}
