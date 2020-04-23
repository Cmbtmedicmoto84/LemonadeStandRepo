using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Weather
    {
        // member variables (HAS A)
        private int tempVariableOne;
        private int tempVariableTwo;
        private int tempCheckRoll;
        public List<string> forecastChoices;
        private int weatherCondition;
        public string forecast;


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
        public int TempCheckRoll
        {
            get
            {
                return tempCheckRoll;
            }
        }
        public int WeatherCond
        {
            get
            {
                return weatherCondition;
            }
        }

        // constructor (SPAWNER)
        public Weather()
        {
            forecastChoices = new List<string>() { "Sunny", "Cloudy", "Overcast", "Raining", "Windy", "Warm", "Humid" };
            tempVariableOne = random.Next(55, 68);
            tempVariableTwo = random.Next(69, 97);

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
            if (tempCheckOne == 0 && tempCheckOne <= 9 && forecast == "Raining" || forecast == "Cloudy" || forecast == "Windy" || forecast == "Overcast")
            {
                Console.WriteLine("Todays temperature will be " + tempVariableOne + " degrees and " + forecast + "! We might not see many customers today.");
                tempVariableOne++;
            }
            else if (tempCheckTwo >= 10 && forecast == "Sunny" || forecast == "Warm" || forecast == "Humid")
            {
                Console.WriteLine("Todays temperature is looking to be at " + tempVariableTwo + " degrees and " + forecast + "!! This weather should bring in the crowds!!!");
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
