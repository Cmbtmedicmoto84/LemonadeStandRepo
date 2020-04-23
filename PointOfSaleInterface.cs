using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    interface PointOfSaleInterface
    {
        void GetNumberOfItems();

        void CalculateTransactionAmount();

        void PayMoneyForItems();

        void AddLemonsToInventory();
        void AddSugarCubesToInventory();
        void AddIceCubesToInventory();
        void AddCupsToInventory();
    }
}
