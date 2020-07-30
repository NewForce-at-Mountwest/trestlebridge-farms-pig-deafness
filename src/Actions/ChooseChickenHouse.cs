using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
    public class ChooseChickenHouse
    {
        public static void CollectInput(Farm farm, IFeatherProducing animal)
        {
            Utils.Clear();

            bool Placed = false;
            while (Placed == false)
            {
                for (int i = 0; i < farm.ChickenHouses.Count; i++)
                {
                    Console.WriteLine(farm.ChickenHouses[i].Capacity == farm.ChickenHouses[i].chickensInChickenHouse
                        ? $"{i + 1}. Chicken House (Full)"
                        : $"{i + 1}. Chicken House ({farm.ChickenHouses[i].chickensInChickenHouse} Chickens)");
                }

                Console.WriteLine();

                Console.WriteLine($"Where would you like to place the {animal.GetType().Name}?");

                Console.Write("> ");

                try
                {
                    int choice = Int32.Parse(Console.ReadLine());
                    
                    if (farm.ChickenHouses[choice - 1].chickensInChickenHouse == farm.ChickenHouses[choice - 1].Capacity)
                    {
                        Console.WriteLine("**** That facility is not large enough ****");
                        Console.WriteLine("****     Please choose another one      ****");
                        choice = Int32.Parse(Console.ReadLine());
                    }

                    else
                    {
                        farm.ChickenHouses[choice -1].AddResource(animal);
                        Placed = true;
                        Console.WriteLine("Break Point");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Please enter only numbers");
                }
            }
        }
    }
}