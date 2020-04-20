using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand_Project
{

    public class Weather
    {
        List<ForecastConditions> forecastCondition;

        public Weather()
        {
            forecastCondition = new List<ForecastConditions>();
        }

        public void AddForecastConditions(ForecastConditions forecastConditions)
        {
            forecastCondition.Add(forecastConditions);
        }
    }
}


        
        
        
        
        //public void RunWeather()
        //{
        //    int tempCheckOne = CheckTemp();
        //    int tempCheckTwo = CheckTemp();
        //    CompareVariableWeather(tempCheckOne, tempCheckTwo);

        //    DetermineWeather();
        //    {
        //        Console.ReadLine();
        //    }

        //}
