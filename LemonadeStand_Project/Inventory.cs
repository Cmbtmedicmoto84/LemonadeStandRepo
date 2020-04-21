using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand_Project
{
    public class Inventory
    {
        // member variables (HAS A)
        public List<int> Lemon;
        private int MyLemons;
        public List<int> SugarCube;
        private int MySugarCubes;
        public List<int> IceCube;
        private int MyIceCubes;
        public List<int> Cup;
        private int MyCups;

        //public int Lemons
        //{
        //    get
        //    {
        //        return MyLemons;
        //    }
        //}
        //public int SugarCubes
        //{
        //    get
        //    {
        //        return MySugarCubes;
        //    }
        //}
        //public int IceCubes
        //{
        //    get
        //    {
        //        return MyIceCubes;
        //    }
        //}
        //public int Cups
        //{
        //    get
        //    {
        //        return MyCups;
        //    }
        //}

        // constructor (SPAWNER)
        public Inventory()
        {
            //MyLemons = 0;
            //MySugarCubes = 0;
            //MyIceCubes = 0;
            //MyCups = 0;
        }

        // member methods (CAN DO)
        public void AddLemonsToInventory(int numberOfLemons)
        {
            for (int i = 0; i < numberOfLemons; i++)
            {
                Lemon MyLemon = new Lemon();
                Lemon.Add(MyLemons);
            }
        }

        public void AddSugarCubesToInventory(int numberOfSugarCubes)
        {
            for (int i = 0; i < numberOfSugarCubes; i++)
            {
                SugarCube sugarCube = new SugarCube();
                SugarCube.Add(MySugarCubes);
            }
        }

        public void AddIceCubesToInventory(int numberOfIceCubes)
        {
            for (int i = 0; i < numberOfIceCubes; i++)
            {
                IceCube iceCube = new IceCube();
                IceCube.Add(MyIceCubes);
            }
        }

        public void AddCupsToInventory(int numberOfCups)
        {
            for (int i = 0; i < numberOfCups; i++)
            {
                Cup cup = new Cup();
                Cup.Add(MyCups);
            }
        }

        public void DisplayStartingInventory()
        {
            Console.WriteLine("You are starting your day with a total of " + MyLemons + " lemons, " + MySugarCubes + " sugar cubes, " + MyCups + " cups and " + MyIceCubes + " ice cubes.");
        }

        public void MyInventory()
        {

        }
    }
}
