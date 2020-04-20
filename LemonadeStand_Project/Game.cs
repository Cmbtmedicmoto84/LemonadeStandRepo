using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand_Project
{
    public class Game
    {
        // member variables (HAS A)
        private Player player;
        private List<Date> dates;
        private int currentDay;
        public List<string> weatherConditions;
        // computer player?
        // second human player?
        // time limit = 7 days minimum with 24 hours per day
        public int CurrentDay
        {
            get
            {
                return currentDay;
            }
        }

        // constructor (SPAWNER)
        public Game()
        {
            currentDay = 7;
        }

        // member methods (CAN DO)
        public void TimeToPlay()
        {
            Console.WriteLine("You have " + currentDay +" days to make as much of a profit as you can!  GOOD LUCK!!");
        }


        private void RunGame()
        {

        }

    }
}
