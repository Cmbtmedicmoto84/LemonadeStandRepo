using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand_Project
{
     public class Store
    {
        // member variables (HAS A)
        protected double pricePerLemon;
        protected double pricePerSugarCube;
        protected double pricePerIceCube;
        protected double pricePerCup;

        // constructor (SPAWNER)
        public Store()
        {
            pricePerLemon = .50;
            pricePerSugarCube = .10;
            pricePerIceCube = .01;
            pricePerCup = .25;
        }

        // member methods (CAN DO)
        public void SellLemons(Player player)
        {
            int lemonsToPurchase = UserInterface.GetNumberOfItems("lemons");
            double transactionAmount = CalculateTransactionAmount(lemonsToPurchase, pricePerLemon);
            if (player.myWallet.QuantityOfMoney >= transactionAmount)
            {
                player.myWallet.PayMoneyForItems(transactionAmount);
                player.myInventory.AddLemonsToInventory(lemonsToPurchase);
            }
        }

        public void SellSugarCubes(Player player)
        {
            int sugarToPurchase = UserInterface.GetNumberOfItems("sugar");
            double transactionAmount = CalculateTransactionAmount(sugarToPurchase, pricePerSugarCube);
            if (player.myWallet.QuantityOfMoney >= transactionAmount)
            {
                PerformTransaction(player.myWallet, transactionAmount);
                player.myInventory.AddSugarCubesToInventory(sugarToPurchase);
            }
        }

        public void SellIceCubes(Player player)
        {
            int iceCubesToPurchase = UserInterface.GetNumberOfItems("ice cubes");
            double transactionAmount = CalculateTransactionAmount(iceCubesToPurchase, pricePerIceCube);
            if (player.myWallet.QuantityOfMoney >= transactionAmount)
            {
                PerformTransaction(player.myWallet, transactionAmount);
                player.myInventory.AddIceCubesToInventory(iceCubesToPurchase);
            }
        }

        public void SellCups(Player player)
        {
            int cupsToPurchase = UserInterface.GetNumberOfItems("cups");
            double transactionAmount = CalculateTransactionAmount(cupsToPurchase, pricePerCup);
            if (player.myWallet.QuantityOfMoney >= transactionAmount)
            {
                PerformTransaction(player.myWallet, transactionAmount);
                player.myInventory.AddCupsToInventory(cupsToPurchase);
            }
        }

        private double CalculateTransactionAmount(int itemCount, double itemPricePerUnit)
        {
            double transactionAmount = itemCount * itemPricePerUnit;
            return transactionAmount;
        }

        private void PerformTransaction(Wallet wallet, double transactionAmount)
        {
            wallet.PayMoneyForItems(transactionAmount);
        }
    }
}
