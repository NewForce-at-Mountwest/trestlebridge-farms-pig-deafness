using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Plants;

namespace Trestlebridge.Actions
{
    public class ChoosePlowedField
    {
        public static void CollectInput(Farm farm, ISeedProducing plant)
        {
            Utils.Clear();

            bool Planted = false;
            while (Planted == false)
            {
                //Loop for printing fields with if for seeing if at capacity
                for (int i = 0; i < farm.PlowedFields.Count; i++)
                {
                    // if(i > 0){
                    Console.WriteLine(farm.PlowedFields[i].Capacity == farm.PlowedFields[i].currentNumberInField
                        ? $"{i + 1}. Plowed Field (Full)"
                        : $"{i + 1}. Plowed Field ({farm.PlowedFields[i].currentNumberInField} plants)");
                }

                Console.WriteLine();

                // How can I output the type of animal chosen here?
                Console.WriteLine($"Plant the {plant.GetType().Name} seeds where?");

                Console.Write("> ");
                try
                {
                    int choice = Int32.Parse(Console.ReadLine());
                    /*Checking to see if the field has room for the animal*/
                    if (farm.PlowedFields[choice - 1].currentNumberInField == farm.PlowedFields[choice - 1].Capacity)
                    {
                        Console.WriteLine("**** That facility is not large enough ****");
                        Console.WriteLine("****     Please choose another one      ****");
                        choice = Int32.Parse(Console.ReadLine());
                    }
                    /*If so adding to the field*/
                    else
                    {
                        farm.PlowedFields[choice - 1].AddResource(plant);
                        //Console.WriteLine("Break Point");
                        Console.WriteLine("Plant added to field");
                        Console.ReadLine();
                        Planted = true;
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
