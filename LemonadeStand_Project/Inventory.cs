using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand_Project
{
    public class Inventory
    {
        // member variables (HAS A)
        public List<int> Lemon;
        private int MyLemonsStarting;
        public List<int> SugarCube;
        private int MySugarCubesStarting;
        public List<int> IceCube;
        private int MyIceCubesStarting;
        public List<int> Cup;
        private int MyCupsStarting;
        public int MyLemons;
        public int MySugarCubes;
        public int MyIceCubes;
        public int MyCups;

        // constructor (SPAWNER)
        public Inventory()
        {
            MyLemonsStarting = 0;
            MySugarCubesStarting = 0;
            MyIceCubesStarting = 0;
            MyCupsStarting = 0;
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
            Console.WriteLine("You are starting your day with a total of " + MyLemonsStarting + " lemons, " + MySugarCubesStarting + " sugar cubes, " + MyCupsStarting + " cups and " + MyIceCubesStarting + " ice cubes.");
        }


        public void MyInventory()
        {

        }
    }
}
