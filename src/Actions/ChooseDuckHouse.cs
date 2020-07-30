using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
    public class ChooseDuckHouse
    {
        public static void CollectInput(Farm farm, IEggProducing animal)
        {
            Utils.Clear();
            
            bool Placed = false;
            while (Placed == false)
            {
                for (int i = 0; i < farm.DuckHouses.Count; i++)
                {
                    Console.WriteLine(farm.DuckHouses[i].Capacity == farm.DuckHouses[i].ducksInDuckHouse
                        ? $"{i + 1}. Grazing Field (Full)"
                        : $"{i + 1}. Grazing Field ({farm.DuckHouses[i].ducksInDuckHouse} animals)");
                }

                Console.WriteLine();

                Console.WriteLine($"Where would you like to place the {animal.GetType().Name}?");

                Console.Write("> ");

                try
                {
                    int choice = Int32.Parse(Console.ReadLine());
                    
                    if (farm.DuckHouses[choice - 1].ducksInDuckHouse == farm.DuckHouses[choice - 1].Capacity)
                    {
                        Console.WriteLine("**** That facility is not large enough ****");
                        Console.WriteLine("****     Please choose another one      ****");
                        choice = Int32.Parse(Console.ReadLine());
                    }

                    else
                    {
                        farm.DuckHouses[choice -1].AddResource(animal);
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