using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Player
    {
        // member variables (HAS A)
        public string name;
        public Wallet wallet;
        public Inventory inventory;

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
    }
}
