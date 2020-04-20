using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand_Project
{
    public class Player
    {
        // member variables (HAS A)
        private string name;
        public Wallet myWallet = new Wallet();
        public Inventory myInventory = new Inventory();
        
        public Recipe recipe;
        public Item item; //pitcher

        public string PlayerName
        {
            get
            {
                return name;
            }
        }

        public object wallet
        {
            get 
            {
                return myWallet;
            }

        }

        // constructor (SPAWNER)
        public Player()
        {
            name = "Crystal";
        }

        // member methods (CAN DO)
        // buy more supplies
        public void RunPlayerVariables()
        {
            Console.WriteLine(name + " the following is what you have for inventory and cash.");
            myInventory.DisplayInventoryOnHand();
            myWallet.DisplayCurrentCashOnHand();
        }
        
        // make more lemonade
        // choose lemonade recipe variations

    }
}
