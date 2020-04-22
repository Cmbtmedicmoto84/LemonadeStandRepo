using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand_Project
{
    class ForecastConditions
    {
        Random random = new Random();
        public List<string> forecastChoices;
        public string forecast;
       
        public ForecastConditions()
        {
            forecastChoices = new List<string>() { "Sunny", "Cloudy", "Overcast", "Raining", "Windy", "Warm", "Humid" };
        }
        


        public void ForecastChoice()
        {
            Random random = new Random();
            int weatherCondition = random.Next(forecastChoices.Count);
            forecast = forecastChoices[weatherCondition];
            Console.WriteLine("Looks like it will be " + forecast); 
        }


    }
}
