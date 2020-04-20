using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand_Project
{
    public class Game
    {
        // member variables (HAS A)
        Player player = new Player();
        Date date = new Date();
        Weather weather = new Weather();
        Customer customer = new Customer();

        //public List<string> weatherConditions;
        // second human player?


        // constructor (SPAWNER)
        public Game()
        {
            
        }

        // member methods (CAN DO)
        


        public void RunGame()
        {
            weather.RunWeather();
            weather.DetermineWeather();

            player.RunPlayerVariables();

            date.TimeToPlay();

            customer.WalkToLemonadeStand();
            customer.PurchaseCupOfLemonade();
        }

    }
}
