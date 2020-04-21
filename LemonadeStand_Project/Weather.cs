using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand_Project
{


    public class Weather
    {
        // member variables (HAS A)
        private int tempVariableOne;
        private int tempVariableTwo;
        protected string forecasts;
        public List<string> forecastChoices = new List<string>();
        //public List<string> forecast;
        Random random = new Random();

        //public string ForecastChoices
        //{
        //    get
        //    {
        //        return forecasts;
        //    }
        //}
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
            forecastChoices = new List<string>() { "Sunny", "Cloudy", "Overcast", "Raining", "Windy" };
            tempVariableOne = 71;
            tempVariableTwo = 88;
        }

        // member methods (CAN DO)
        public int CheckTemp()
        {
            int tempCheckRoll = random.Next(1, 2);
            return tempCheckRoll;
        }

        public void CompareVariableWeather(int tempCheckOne, int tempCheckTwo)
        {
            if (tempCheckOne == 1)
            {
                tempVariableOne++;
            }
            else if (tempCheckTwo == 2)
            {
                tempVariableTwo++;
            }
        }

        public void DetermineWeather()
        {
            if (tempVariableOne == 72)
            {
                Console.WriteLine("Todays temperature will be " + tempVariableOne + " degrees!");
            }
            else if (tempVariableTwo == 89)
            {
                Console.WriteLine("Todays temperature is looking to be at " + tempVariableTwo + " degrees!!");
            }
        }
        


        public void RunWeather()
        {
            int tempCheckOne = CheckTemp();
            int tempCheckTwo = CheckTemp();
            CompareVariableWeather(tempCheckOne, tempCheckTwo);
        }
    }
}








