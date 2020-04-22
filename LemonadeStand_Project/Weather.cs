using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand_Project
{
    class Weather
    {
        // member variables (HAS A)
        private int tempVariableOne;
        private int tempVariableTwo;
        public List<string> forecastChoices;
        public string forecast;
        //public string forecasts;

        Random random = new Random();

        public int TempVariableOne
        {
            get
            {
                return tempVariableOne;
            }
        }
        public int TempVariableTwo
        {
            get
            {
                return tempVariableTwo;
            }
        }
        
        // constructor (SPAWNER)
        public Weather()
        {
            forecastChoices = new List<string>() { "Sunny", "Cloudy", "Overcast", "Raining", "Windy", "Warm", "Humid" };
            tempVariableOne = random.Next(71, 88);
            tempVariableTwo = random.Next(89, 97);
        }

        // member methods (CAN DO)
        public int CheckTemp()
        {
            int tempCheckRoll = random.Next(0, 20);
            return tempCheckRoll;
        }

        public int ForecastChoice()
        {
            int weatherCondition = random.Next(forecastChoices.Count);
            forecast = forecastChoices[weatherCondition];
            return weatherCondition;
        }

        public void CompareVariableWeather(int tempCheckOne, int tempCheckTwo)
        {
            if (tempCheckOne == 0 && tempCheckOne <=9 && forecast == "Raining" || forecast == "Cloudy" || forecast == "Windy" || forecast == "Overcast")
            {
                Console.WriteLine("Todays temperature will be " + tempVariableOne + " degrees and " + forecast + "!");
                tempVariableOne ++;
            }
            else if (tempCheckTwo >= 10 && forecast == "Sunny" || forecast == "Warm" || forecast == "Humid")
            {
                Console.WriteLine("Todays temperature is looking to be at " + tempVariableTwo + " degrees and " + forecast + "!!");
                tempVariableTwo++;
            }
        }

        

        public void RunWeather()
        {
            int tempCheckOne = CheckTemp();
            int tempCheckTwo = CheckTemp();
            int forecast = ForecastChoice();

            CompareVariableWeather(tempVariableOne, tempVariableTwo);
        }
    }
}








