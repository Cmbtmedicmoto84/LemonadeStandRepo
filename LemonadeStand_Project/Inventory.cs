using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand_Project
{
    class Inventory
    {
        // member variables (HAS A)
        public List<Lemon> lemons;
        private int MyLemonsStarting;
        public List<SugarCube> sugarCubes;
        private int MySugarCubesStarting;
        public List<IceCube> iceCubes;  //?????
        private int MyIceCubesStarting;
        public List<Cup> cups;  //?????
        private int MyCupsStarting;
        public int MyLemons;
        public int MySugarCubes;
        public int MyIceCubes;
        public int MyCups;

        // constructor (SPAWNER)
        public Inventory()
        {
            lemons = new List<Lemon>();
            sugarCubes = new List<SugarCube>();
            iceCubes = new List<IceCube>();
            cups = new List<Cup>();
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
                Lemon lemon = new Lemon();
                lemons.Add(lemon);
            }
        }

        public void AddSugarCubesToInventory(int numberOfSugarCubes)
        {
            for (int i = 0; i < numberOfSugarCubes; i++)
            {
                SugarCube sugarCube = new SugarCube();
                sugarCubes.Add(sugarCube);
            }
        }

        public void AddIceCubesToInventory(int numberOfIceCubes)
        {
            for (int i = 0; i < numberOfIceCubes; i++)
            {
                IceCube iceCube = new IceCube();
                iceCubes.Add(iceCube);
            }
        }

        public void AddCupsToInventory(int numberOfCups)
        {
            for (int i = 0; i < numberOfCups; i++)
            {
                Cup cup = new Cup();
                cups.Add(cup);
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
