using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand_Project
{
    class Game
    {
        // member variables (HAS A)
        private Player player;
        private List<Date> dates;
        private int currentDay;
        public List<string> weatherConditions;
        // computer player?
        // second human player?
        // time limit = 7 days minimum with 24 hours per day


        // constructor (SPAWNER)
        public Game()
        {
            weatherConditions = new List<string>() { "Sunny", "Overcast", "Cloudy", "Slight Showers" };
        }

        // member methods (CAN DO)



        private void RunGame()
        {

        }

    }
}
