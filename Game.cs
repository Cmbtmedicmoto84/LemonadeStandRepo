using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
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
    }
}
