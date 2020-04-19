using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand_Project
{
    public class IceCube : Item
    {
        // member variables (HAS A)
        // melting point(time)
        string name;
        public List<int> cubesOfIce = new List<int>();

        // constructor (SPAWNER)
        public IceCube()
        {
            name = "ice cube";
        }

        // member methods (CAN DO)
        // melt
    }
}
