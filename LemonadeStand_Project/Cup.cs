using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand_Project
{
    class Cup : Item
    {
        // member variables (HAS A)
        public int capacity;
        public string capacityMeasure;

        // constructor (SPAWNER)
        public Cup()
        {
            name = "cup";
            capacity = 10;
            capacityMeasure = "ounces";
        }

        // member methods (CAN DO)



    }
}
