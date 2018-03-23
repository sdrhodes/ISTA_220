using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    class Soybean : Crops 
    {
        public Soybean()
        {
            CropType = "Soybeans";
            CropPurpose = "Protein";
            CropColor = "Green";
        }
    }
}
