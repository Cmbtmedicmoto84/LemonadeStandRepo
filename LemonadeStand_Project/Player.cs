using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand_Project
{
    class Player
    {
        // member variables (HAS A)
        public Inventory inventory;
        public Wallet wallet;

        // constructor (SPAWNER)
        public Player()
        {
            inventory = new Inventory();
            wallet = new Wallet();
        }

        // member methods (CAN DO)
    }
}
