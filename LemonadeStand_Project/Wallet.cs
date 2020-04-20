using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand_Project
{
    public class Wallet
    {
        private double quantityOfMoney;

        //properties
        public double QuantityOfMoney
        {
            get
            {
                return quantityOfMoney;
            }
        }

        //constructor
        public Wallet()
        {
            quantityOfMoney = 20.00;
        }

        //member methods
        public void PayMoneyForItems(double transactionAmount)
        {
            quantityOfMoney -= transactionAmount;
        }

        public void DisplayCurrentCashOnHand()
        {
            Console.WriteLine("You have $" + quantityOfMoney + " available.");
        }
    }
}
