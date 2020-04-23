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
            if (weather.WeatherCond == 0 && weather.WeatherCond == 5 && weather.WeatherCond == 6)
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

        //stuff to add 

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

    ////public void LeaveLemonadeStand()  'use for customers on walk but dont buy'
    ////{
    ////    if (isInterestedInPurchase = !isInterestedInPurchase)
    ////    {
    ////        Console.WriteLine("The customer looked but did not buy.");
    ////    }
    ////}




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
