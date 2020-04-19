using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand_Project
{
    public class Recipe
    {
        public List<Lemon> lemons;
        public List<SugarCube> sugarCubes;
        public List<IceCube> iceCubes;
        public List<Cup> cups;



        // constructor (SPAWNER)
        public Recipe()
        {
            public List<int> cubesOfIce = new List<int>();
            public List<int> lemonsToAdd = new List<int>();
            public List<int> cubesOfSugar = new List<int>();
        
    
    

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
    }
}
