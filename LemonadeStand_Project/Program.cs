using System;

namespace LemonadeStand_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            Weather weather = new Weather();

            weather.RunWeather();
            weather.DetermineWeather();
           
            //
            Wallet myWallet = new Wallet();

            
            myWallet.DisplayCurrentCashOnHand();

            //
            Game game = new Game();

            game.TimeToPlay();

            //
            Customer customer = new Customer();

            customer.WalkToLemonadeStand();
            customer.PurchaseCupOfLemonade();
        
        
        }
    }
}
