using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand_Project
{
    class ForecastConditions : Weather
    {
        List<string> forecastedConditions = new List<string>();
        Random random = new Random();
        public int CheckForecast()
        {
            int forecastCheckRoll = random.Next(1, 2);
            Console.ReadLine();
            return forecastCheckRoll;
        }

    }
}
