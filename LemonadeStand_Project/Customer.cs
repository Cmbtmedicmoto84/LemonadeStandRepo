using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand_Project
{
    public class Customer
    {
        // member variables (HAS A)
        public string name;
        public bool customerAtLemonadeStand;
        public bool isInterestedInPurchase;
        //Weather weather;
        //ForecastConditions ForecastConditions;
        //private List<string> names;


        // constructor (SPAWNER)
        public Customer()
        {
            customerAtLemonadeStand = false;
            isInterestedInPurchase = false;
        }

        // member methods (CAN DO)
        public void WalkToLemonadeStand()
        {
            if(customerAtLemonadeStand == true)
            {
                //weather, price variable to influence purchase?
                if (isInterestedInPurchase = !isInterestedInPurchase)
                {
                    Console.WriteLine("A customer has stopped at your stand!");
                }

            }
            else if (customerAtLemonadeStand == false)
            {
                //not interested due to weather, price variables?
                LeaveLemonadeStand();
            }
        }

        public void PurchaseCupOfLemonade()
        {
            if(isInterestedInPurchase = !isInterestedInPurchase)
            {
                Console.WriteLine("The customer purchased a cup of lemonade!");
            }
            else
            {
                Console.WriteLine("The customer is not interested and continued walking.");
            }
        }


        public void LeaveLemonadeStand()
        {
            //how to have customer leave after purchasing or not interested in purchasing?
            if (isInterestedInPurchase = !isInterestedInPurchase)
            {
                Console.WriteLine("The customer looked but did not buy.");
            }
            else
            {
                
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
