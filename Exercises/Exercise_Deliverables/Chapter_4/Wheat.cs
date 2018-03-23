using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    class Wheat:Crops
    {
        public Wheat()
        {
            CropType = "Wheat";
            CropPurpose = "Flour";
            CropColor = "Tan";
        }
    }
}
