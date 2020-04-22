using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand_Project
{
    public interface PointOfSaleInterface
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
