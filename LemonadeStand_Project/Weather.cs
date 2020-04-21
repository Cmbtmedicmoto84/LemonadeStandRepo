﻿using System;
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
            tempVariableOne = random.Next(71, 88);
            tempVariableTwo = random.Next(89, 97);
        }

        // member methods (CAN DO)
        public int CheckTemp()
        {
            int tempCheckRoll = random.Next(0, 20);
            return tempCheckRoll;
        }

        public void CompareVariableWeather(int tempCheckOne, int tempCheckTwo)
        {
            if (tempCheckOne == 0 || tempCheckOne <=9)
            {
                Console.WriteLine("Todays temperature will be " + tempVariableOne + " degrees!");
                tempVariableOne ++;
            }
            else if (tempCheckTwo >= 10)
            {
                Console.WriteLine("Todays temperature is looking to be at " + tempVariableTwo + " degrees!!");
                tempVariableTwo++;
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








