using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand_Project
{
    public class Cup : Item
    {
        // member variables (HAS A)
        public int capacity;
        public string capacityMeasure;
        //public string name;

        // constructor (SPAWNER)
        public Cup()
        {
            capacity = 10;
            capacityMeasure = "ounces";
        }

        // member methods (CAN DO)
        // hold items for lemonade
    }
}
