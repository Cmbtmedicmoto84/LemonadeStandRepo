using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand_Project
{
    class Weather
    {
        // member variables (HAS A)
        public string condition;
        public int tempVariable1;
        public int tempVariable2;
        Random random = new Random();
        

        // constructor (SPAWNER)
        public Weather()
        {
            tempVariable1 = 68;
            tempVariable2 = 75;
        }

        // member methods (CAN DO)
            
        public int CheckTemp()
        {
            int tempLevelRoll = random.Next(1, 2);
            Console.WriteLine();
            //Console.ReadLine();
            return tempLevelRoll;
        }

        public void CompareVariableWeather(int tempCheck1, int tempCheck2)
        {
            if (tempCheck1 < tempCheck2)
            {
                Console.WriteLine("");
                tempVariable2++;
            }
            else if (tempCheck1 > tempCheck2)
            {
                Console.WriteLine("");
                tempVariable1++;
            }
            else
            {
                Console.WriteLine("");
            }
        }

        public void DetermineWeather()
        {
            if (tempVariable1 == 1)
            {
                Console.WriteLine("Todays temperature will be " + tempVariable1 + " degrees!");
            }
            else if (tempVariable2 == 2)
            {
                Console.WriteLine("Todays temperature is looking to be at " + tempVariable2 + " degrees!!");
            }

        }


        



        public void RunWeather()
        {
            while(tempVariable1 == 1 && tempVariable2 < 2)
            {
                int tempCheck1 = CheckTemp();
                int tempCheck2 = CheckTemp();
                CompareVariableWeather(tempCheck1, tempCheck2);
            }
            DetermineWeather();
            {
                Console.ReadLine();
            }
        }
        
    }
}
