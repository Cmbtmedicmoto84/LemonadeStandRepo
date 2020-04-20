using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand_Project
{


    public class Weather
    {
        // member variables (HAS A)
        public int tempVariableOne;
        public int tempVariableTwo;
        Random random = new Random();

        // constructor (SPAWNER)
        public Weather()
        {
            tempVariableOne = 71;
            tempVariableTwo = 88;
        }

        // member methods (CAN DO)
        public int CheckTemp()
        {
            int tempCheckRoll = random.Next(1, 2);
            return tempCheckRoll;
        }

        public void CompareVariableWeather(int tempCheckOne, int tempCheckTwo)
        {
            if (tempCheckOne == 1)
            {
                tempVariableOne++;
            }
            else if (tempCheckTwo == 2)
            {
                tempVariableTwo++;
            }
        }

        public void DetermineWeather()
        {
            if (tempVariableOne == 72)
            {
                Console.WriteLine("Todays temperature will be " + tempVariableOne + " degrees!");
            }
            else if (tempVariableTwo == 89)
            {
                Console.WriteLine("Todays temperature is looking to be at " + tempVariableTwo + " degrees!!");
            }
        }



        public void RunWeather()
        {
            int tempCheckOne = CheckTemp();
            int tempCheckTwo = CheckTemp();
            CompareVariableWeather(tempCheckOne, tempCheckTwo);
        }
    }
}








