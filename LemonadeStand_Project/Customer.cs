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
        private List<string> names;


        // constructor (SPAWNER)
        public Customer()
        {
            customerAtLemonadeStand = false;
            isInterestedInPurchase = false;
        }

        // member methods (CAN DO)

        public void WalkToLemonadeStand()
        {
            //how to have customer automatically walk to stand?
            if(isInterestedInPurchase == false)
            {
                //weather, price variable to influence purchase?
                if (customerAtLemonadeStand == true)
                {
                    LeaveLemonadeStand();
                }

            }
            else
            {
                //not interested due to weather, price variables?
                Console.WriteLine("Customer purchased a cup of lemonade!");
            }
        }

        public void PurchaseCupOfLemonade()
        {
            isInterestedInPurchase = !isInterestedInPurchase;
            Console.WriteLine("The customer left and did not purchase a cup of Lemonade!");
        }


        public void LeaveLemonadeStand()
        {
            //how to have customer leave after purchasing or not interested in purchasing?
            if (isInterestedInPurchase == false)
            {
                Console.WriteLine("Customer left");
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
