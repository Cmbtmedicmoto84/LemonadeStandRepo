using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand_Project
{
    public class Player
    {
        // member variables (HAS A)
        public string name;
        public Wallet myWallet = new Wallet();
        public Inventory myInventory = new Inventory();
        public Store myStore = new Store();
        
        public Recipe recipe;
        public Item item; //pitcher

        //public string PlayerName
        //{
        //    get
        //    {
        //        return name;
        //    }
        //}

        public object UserStore
        {
            get
            {
                return myStore;
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
            myInventory.DisplayStartingInventory();
            myWallet.DisplayCurrentCashOnHand();




        }
        
        // make more lemonade
        // choose lemonade recipe variations

    }
}
