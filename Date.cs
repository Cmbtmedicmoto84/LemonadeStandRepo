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
        public List<string> dayOfWeek;
        private string weekDays;
        public int daysOfWeek;
        private string days;
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
            dayOfWeek = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            daysOfWeek = 0;
            daysToPlay = 7;
            
        }

        // member methods (CAN DO)
        public void TimeToPlay()
        {
            Console.WriteLine("You have " + daysToPlay + " days to make as much of a profit as you can!  GOOD LUCK!!");
        }

        public int DaysOfWeek()
        {
            int daysOfWeek = dayOfWeek.Count;
            days = dayOfWeek[daysOfWeek];
            return daysOfWeek;
        }

        public void DayToday()
        {
            string[] weekDays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            if (daysOfWeek == 0)
            {
                Console.WriteLine("Today is " + days);
                daysOfWeek++;
            }
            else if(daysOfWeek == 1)
            {
                Console.WriteLine("Today is " + days);
                daysOfWeek++;
            }
            else if (daysOfWeek == 2)
            {
                Console.WriteLine("Today is " + days);
                daysOfWeek++;
            }
            else if (daysOfWeek == 3)
            {
                Console.WriteLine("Today is " + days);
                daysOfWeek++;
            }
            else if (daysOfWeek == 4)
            {
                Console.WriteLine("Today is " + days);
                daysOfWeek++;
            }
            else if (daysOfWeek == 5)
            {
                Console.WriteLine("Today is " + days);
                daysOfWeek++;
            }
            else if (daysOfWeek == 6)
            {
                Console.WriteLine("Today is " + days);
            }
        }

        public void RunDate()
        {
            int weekDays = DaysOfWeek();
            DayToday();
        }
    }
}
