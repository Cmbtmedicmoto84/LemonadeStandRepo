using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand_Project
{
    public class Customer
    {
        // member variables (HAS A)
        public List<int> customersTeamOne;
        public List<int> customersTeamTwo;
        public int customerOne;
        public int customerTwo;
        public bool customerAtLemonadeStand;
        public bool isInterestedInPurchase;
        Weather weather = new Weather();
        ForecastConditions forecastConditions = new ForecastConditions();

        // constructor (SPAWNER)
        public Customer()
        {
            customersTeamOne = new List<int>(100);
            customersTeamTwo = new List<int>(55);
            customerAtLemonadeStand = false;
            isInterestedInPurchase = false;
        }

        // member methods (CAN DO)
        public void CustomerWeatherBehavior()
        {
            Random random = new Random();
            int custTeamOne = random.Next(customersTeamOne.Count);
            int custTeamTwo = random.Next(customersTeamTwo.Count);
            customerOne = customersTeamOne[custTeamOne];
            customerTwo = customersTeamTwo[custTeamTwo];
        }

        //public void CustWeatherChoice()
        //{
        //    if(customerOne >= 55)
        //    {
                
        //    }
        //}

        public void WalkToLemonadeStand()
        {
            if(customerAtLemonadeStand == true)
            {
                //weather, price variable to influence purchase?
                if (isInterestedInPurchase = !isInterestedInPurchase)
                {
                    if (customerOne >= 55) 
                    {
                        Console.WriteLine("A customer has stopped at your stand!");
                    }   
                }
            }
        }

        public void PurchaseCupOfLemonade()
        {
            if(isInterestedInPurchase = !isInterestedInPurchase)
            {
                if (customerOne >= 55)
                {
                    Console.WriteLine("The customer purchased a cup of lemonade!");
                }       
            }
            else if (customerTwo < 55)
            {
                Console.WriteLine("The customer said it wasn't the best weather for cold lemonade and continued walking.");
            }
        }


        public void LeaveLemonadeStand()
        {
            //how to have customer leave after purchasing or not interested in purchasing?
            if (isInterestedInPurchase = !isInterestedInPurchase)
            {
                Console.WriteLine("The customer looked but did not buy.");
            }
        }




        //part of saving txt file? member variable
        //public string CustomerName { get { return name; } set { name = value; } }

        // possible for saving txt file information?
        //private bool Validate()
        //{
        //    Console.WriteLine("Validated");
        //    return true;
        //}

        //public bool Save()
        //{
        //    Validate();
        //    DBSetUp();
        //    return true;
        //}

        //private bool DBSetUp()
        //{
        //    Console.WriteLine("DB Set up");
        //    return true;
        //}

    }
}
