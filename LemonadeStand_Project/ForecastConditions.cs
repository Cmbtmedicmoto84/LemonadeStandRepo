using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand_Project
{
    public class ForecastConditions : Weather
    {
        //Weather weather = new Weather();
        Random random = new Random();
        public List<string> forecasts;
        public string forecast;
       
        public ForecastConditions()
        {
            forecasts = new List<string>() { "Sunny" , "Cloudy" , "Overcast" , "Raining" , "Windy" };
        }
        


        public void ForecastChoice()
        {
            Random random = new Random();
            int weatherCondition = random.Next(forecasts.Count);
            forecast = forecasts[weatherCondition];
            Console.WriteLine("Looks like it will be " + forecast); 
        }


    }
}
