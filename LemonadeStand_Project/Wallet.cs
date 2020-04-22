using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand_Project
{
    class Wallet
    {
        private double money;

        //properties
        public double Money
        {
            get
            {
                return money;
            }
        }

        //constructor
        public Wallet()
        {
            money = 20.00;
        }

        //member methods
        public void PayMoneyForItems(double transactionAmount)
        {
            money -= transactionAmount;
        }

        public void DisplayCurrentCashOnHand()
        {
            Console.WriteLine("You have $" + money + " available.");
        }
    }
}
