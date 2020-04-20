using System;

namespace LemonadeStand_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Weather weather = new Weather();

            weather.RunWeather();
            weather.DetermineWeather();


            Customer customer = new Customer();

            customer.WalkToLemonadeStand();
            customer.PurchaseCupOfLemonade();
        
        
        }
    }
}
