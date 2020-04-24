using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Date
    {
        // member variables (HAS A)
        private int daysToPlay;
        public List<string> daysOfWeek;
        public int dayOfWeek;
        //public string dayNames;
        //Date date = new Date();

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
            daysToPlay = 7;
        }
        public Date(List<string> daysOfWeek, int dayOfWeek)
        {
            daysOfWeek = new List<string> { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            dayOfWeek = 0;            
        }

        // member methods (CAN DO)
        public void TimeToPlay()
        {
            Console.WriteLine("You have " + daysToPlay + " days to make as much of a profit as you can!  GOOD LUCK!!");
        }

        public void DayToday()
        {
            if (dayOfWeek == 0)
            {
                Console.WriteLine("Today is " + daysOfWeek);
                dayOfWeek++;
            }
            else if(dayOfWeek == 1)
            {
                Console.WriteLine("Today is " + daysOfWeek);
                dayOfWeek++;
            }
            else if (dayOfWeek == 2)
            {
                Console.WriteLine("Today is " + daysOfWeek);
                dayOfWeek++;
            }
            else if (dayOfWeek == 3)
            {
                Console.WriteLine("Today is " + daysOfWeek);
                dayOfWeek++;
            }
            else if (dayOfWeek == 4)
            {
                Console.WriteLine("Today is " + daysOfWeek);
                dayOfWeek++;
            }
            else if (dayOfWeek == 5)
            {
                Console.WriteLine("Today is " + daysOfWeek);
                dayOfWeek++;
            }
            else
            {
                Console.WriteLine("Today is " + daysOfWeek);
            }
        }

        public void RunDate()
        {   
            DayToday();
        }
    }
}
