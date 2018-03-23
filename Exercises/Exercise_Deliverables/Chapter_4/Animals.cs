using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    public class Animals
    {
        private string animalType;
        private string animalName;
        private string animalNoise;
        private string animalColor;

        public string AnimalType
        {
            get { return animalType; }
            set { animalType = value; }
        }
        public string AnimalName
        {
            get { return animalName; }
            set { animalName = value; }
        }
        public string AnimalNoise
        {
            get { return animalNoise; }
            set { animalNoise = value; }
        }
        public string AnimalColor
        {
            get { return animalColor; }
            set { animalColor = value; }
        }
    }
}
