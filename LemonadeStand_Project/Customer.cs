using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace LemonadeStand_Project
{
    class Customer
    {
        // member variables (HAS A)
        //place in game class????
        public bool isOnWalk;
        public bool isThirsty;

        // constructor (SPAWNER)
        public Customer()
        {
            isOnWalk = false;
            isThirsty = false;
        }

        //methods
        public void Walk()
        {
            isOnWalk = !isOnWalk;
        }
        public void Thirsty()
        {
            if (isOnWalk == true)
            {
                if (isThirsty != false)
                {
                    NotThirsty();
                }

                isThirsty = !isThirsty;
            }
        }
        public void NotThirsty()
        {
            //add dot notation for decision
            if (isOnWalk == true)
            {
                isThirsty = false;     //not on walk
            }
            else if (isOnWalk == false)
            {
                isThirsty = true;      //is on a walk and not thirsty
            }
        }
    }
}
