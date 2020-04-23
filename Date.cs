using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Date
    {
        // member variables (HAS A)
        private int daysToPlay;
        //Weather weather = new Weather();
        public List<string> currentDay;

        public int DaysToPlay
        {
            get
            {
                return daysToPlay;
            }
        }

        // constructor (SPAWNER)
        public Date()
        {
            currentDay = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            daysToPlay = 7;
        }

        // member methods (CAN DO)
        public void TimeToPlay()
        {
            Console.WriteLine("You have " + daysToPlay + " days to make as much of a profit as you can!  GOOD LUCK!!");
        }

        public void Calendar()
        {

        }
    }
}
