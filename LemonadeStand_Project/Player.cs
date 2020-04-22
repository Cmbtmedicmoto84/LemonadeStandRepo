using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand_Project
{
    class Player
    {
        // member variables (HAS A)
        public string name;
        public Wallet wallet;
        public Inventory inventory;
        
        //public Recipe recipe;
        //public Item item; //pitcher

        // constructor (SPAWNER)
        public Player()
        {
            inventory = new Inventory();
            wallet = new Wallet();
            name = "Crystal";
        }

        // member methods (CAN DO)

        public void RunPlayerVariables()
        {
            Console.WriteLine(name + " the following is what you have for inventory and cash.");
            wallet.DisplayCurrentCashOnHand();
            inventory.DisplayStartingInventory();
        }

        

        // make more lemonade
        // choose lemonade recipe variations

    }
}
