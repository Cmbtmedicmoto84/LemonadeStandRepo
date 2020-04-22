﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace LemonadeStand_Project
{
    public class Customer
    {
        // member variables (HAS A)
        private int customersGoodWeather;
        private int customersCrummyWeather;
        public int customerOne;
        public int customerTwo;
        public bool isCustomerAtStand;
        public bool isInterestedInPurchase;
        public bool isCustomerOneInterested;
        public bool isCustomerTwoInterested;
        Weather weather = new Weather();
        Random random = new Random();


        // constructor (SPAWNER)
        public Customer()
        {
            customersGoodWeather = random.Next(71, 88);
            customersCrummyWeather = random.Next(89, 97);
            isCustomerAtStand = false;
            isInterestedInPurchase = false;
        }

        public int CheckWeather()
        {
            int weatherCheckRoll = random.Next(0, 20);
            return weatherCheckRoll;
        }

        // member methods (CAN DO)
        public void CompareCustomerBehavior(int custCheckOne, int custCheckTwo)
        {
            if (custCheckOne == 0 || custCheckOne <= 9)
            {
                Console.WriteLine("Todays temperatures should bring lots of customers!");
            }
            else if (custCheckTwo >= 10)
            {
                Console.WriteLine("I don't think todays temperatures are going to bring many people out for lemonade!");
            }

        }

        public void WalkToLemonadeStand()
        {
            
            if (isCustomerAtStand == !isCustomerAtStand)
            {
                Console.WriteLine("A customer has stopped at your stand!");
            }
            else
            {
                LeaveLemonadeStand();
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



        public void RunBehaviors()
        {
            int custCheckOne = CheckWeather();
            int custCheckTwo = CheckWeather();
            CompareCustomerBehavior(custCheckOne, custCheckTwo);
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
