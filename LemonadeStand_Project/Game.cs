using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand_Project
{
    class Game
    {
        // member variables (HAS A)
        Player player = new Player();
        Date date = new Date();
        Weather weather = new Weather();
        Customer customer = new Customer();
        Store store = new Store();

        // second human player?

        // constructor (SPAWNER)
        public Game()
        {
            

        }

        // member methods (CAN DO)
        


        public void RunGame()
        {
            weather.RunWeather();

            player.RunPlayerVariables();

            date.TimeToPlay();

            customer.RunBehaviors();

            customer.WalkToLemonadeStand();
            customer.PurchaseCupOfLemonade();
        }

    }
}
