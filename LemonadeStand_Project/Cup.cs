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
        public string name;
        //public string name;

        // constructor (SPAWNER)
        public Cup()
        {
            name = "cup";
            capacity = 10;
            capacityMeasure = "ounces";
        }

        // member methods (CAN DO)
        // hold items for lemonade
    }
}
