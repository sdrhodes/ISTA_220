using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    public class Crops
    {
        private string cropType;
        private string cropName;
        private string cropPurpose;
        private string cropColor;

        public string CropType
        {
            get { return cropType; }
            set { cropType = value; }
        }
        public string CropName
        {
            get { return cropName; }
            set { cropName = value; }
        }
        public string CropPurpose
        {
            get { return cropPurpose; }
            set { cropPurpose = value; }
        }
        public string CropColor
        {
            get { return cropColor; }
            set { cropColor = value; }
        }
    }
}
