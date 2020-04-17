using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand_Project
{
    class Player
    {
        // member variables (HAS A)
        public string name;
        public Inventory inventory;
        public Wallet wallet;
        public Recipe recipe;
        public Item item; //pitcher

        // constructor (SPAWNER)
        public Player()
        {
            inventory = new Inventory();
            wallet = new Wallet();
        }

        // member methods (CAN DO)
        // buy more supplies
        // make more lemonade
        // choose lemonade recipe variations

    }
}
