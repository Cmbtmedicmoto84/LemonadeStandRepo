using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand_Project
{
    class Weather
    {
        // member variables (HAS A)
        public string condition;
        public int temperatureLevel;
        Random random = new Random();
        

        // constructor (SPAWNER)
        public Weather()
        {
            int temperatureLevel = random.Next(68, 95); //????Correct??????
            Console.ReadLine();
        }
        public Weather(double temperatureLevel)
        {
            
            if(temperatureLevel > 68.00)
            {
                Console.WriteLine("Todays temperatures should climb above " + temperatureLevel);
                Console.ReadLine();
            }
        }

        // member methods (CAN DO)
    }
}
