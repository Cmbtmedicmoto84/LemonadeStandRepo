using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand_Project
{
    public class Date
    {
        // member variables (HAS A)
        private int currentDay;

        public int CurrentDay
        {
            get
            {
                return currentDay;
            }
        }

        // constructor (SPAWNER)
        public Date()
        {
            currentDay = 7;
        }

        // member methods (CAN DO)
        public void TimeToPlay()
        {
            Console.WriteLine("You have " + currentDay + " days to make as much of a profit as you can!  GOOD LUCK!!");
        }
    }
}
