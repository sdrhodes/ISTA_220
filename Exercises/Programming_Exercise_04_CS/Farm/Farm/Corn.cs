using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    class Corn : Crops
    {
        public Corn()
        {
            CropType = "Corn";
            CropPurpose = "Silage";
            CropColor = "Yellow";
        }
    }
}
