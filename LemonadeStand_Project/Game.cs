using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand_Project
{
    class Game
    {
        // member variables (HAS A)
        public List<string> customers = new List<string>();
        Customer customer = new Customer();
        Player player = new Player();
        Date date = new Date();
        Weather weather = new Weather();
        Store store = new Store();

        // constructor (SPAWNER)
        public Game()
        {
            customer = new Customer();
        }

        // member methods (CAN DO)
        public void WeatherDecision()
        {
            if (weather.TempCheckOne == 0 && weather.TempCheckOne <= 9 &&  forecast == "Raining" || forecast == "Cloudy" || forecast == "Windy" || forecast == "Overcast")
            {

            }
        }


        public void RunGame()
        {
            weather.RunWeather();

            player.RunPlayerVariables();

            date.TimeToPlay();
            customer.Walk();
            customer.Thirsty();
            customer.NotThirsty();

        }

        //stuff to add possibly
        // public int CheckWeather()
    //    {
    //        int weatherCheckRoll = random.Next(0, 20);
    //        if(weatherCheckRoll <= 9)
    //        {
                
    //        }
    //        return weatherCheckRoll;
    //    }

    //public void PurchaseCupOfLemonade()
    //{
    //    if (isInterestedInPurchase = !isInterestedInPurchase)
    //    {
    //        if (customerOne >= 10)
    //        {
    //            Console.WriteLine("The customer purchased a cup of lemonade!");
    //        }
    //    }
    //    else if (customerTwo < 10)
    //    {
    //        Console.WriteLine("The customer said it wasn't the best weather for cold lemonade and continued walking.");
    //    }
    //}

    ////public void LeaveLemonadeStand()
    ////{
    ////    if (isInterestedInPurchase = !isInterestedInPurchase)
    ////    {
    ////        Console.WriteLine("The customer looked but did not buy.");
    ////    }
    ////}



    //public void RunBehaviors()
    //{
    //    int custCheckOne = CheckWeather();
    //    int custCheckTwo = CheckWeather();

    //    //CompareCustomerBehavior(customersCrummyWeather, customersGoodWeather);
    //}




    ////part of saving txt file? member variable
    ////public string CustomerName { get { return name; } set { name = value; } }

    //// possible for saving txt file information?
    ////private bool Validate()
    ////{
    ////    Console.WriteLine("Validated");
    ////    return true;
    ////}

    ////public bool Save()
    ////{
    ////    Validate();
    ////    DBSetUp();
    ////    return true;
    ////}

    ////private bool DBSetUp()
    ////{
    ////    Console.WriteLine("DB Set up");
    ////    return true;
    ////}


}

}
