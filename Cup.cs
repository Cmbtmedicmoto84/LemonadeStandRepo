using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
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
