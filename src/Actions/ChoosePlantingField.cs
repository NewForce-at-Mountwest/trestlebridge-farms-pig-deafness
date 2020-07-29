using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Plants;

namespace Trestlebridge.Actions
{
    public class ChoosePlantingField
    {
        public static void CollectCompostPlantInput(Farm farm, ICompostProducing plant)
        {
            Utils.Clear();

            bool Planted = false;
            while (Planted == false)
            {
                //Loop for printing fields with if for seeing if at capacity
                for (int i = 0; i < farm.NaturalFields.Count; i++)
                {
                    // if(i > 0){
                    Console.WriteLine(farm.NaturalFields[i].Capacity == farm.NaturalFields[i].currentNumberInField
                        ? $"{i + 1}. Natural Field (Full)"
                        : $"{i + 1}. Natural Field ({farm.NaturalFields[i].currentNumberInField} plants)");

                    for (int j = 0; j < farm.PlowedFields.Count; j++)
                    {
                        Console.WriteLine(farm.PlowedFields[j].Capacity == farm.PlowedFields[j].currentNumberInField
                        ? $"{j + 1}. Plowed Field (Full)"
                        : $"{farm.NaturalFields.Count + j + 1}. Plowed Field ({farm.PlowedFields[j].currentNumberInField} plants)");
                    }

                    Console.WriteLine();

                    // How can I output the type of animal chosen here?
                    Console.WriteLine($"Plant the {plant.GetType().Name} seeds where?");

                    Console.Write("> ");
                    int choice = Int32.Parse(Console.ReadLine());

                    farm.NaturalFields[choice - 1].AddResource(plant);
                    Console.WriteLine("Plant added to field");
                    Console.ReadLine();

                    /*Need to add try to this for error handling*/
                    try
                    {
                        int choice = Int32.Parse(Console.ReadLine());
                        /*Checking to see if the field has room for the animal*/
                        if (farm.GrazingFields[choice - 1].currentNumberInField == farm.GrazingFields[choice - 1].Capacity)
                        {
                            Console.WriteLine("**** That facility is not large enough ****");
                            Console.WriteLine("****     Please choose another one      ****");
                            choice = Int32.Parse(Console.ReadLine());
                        }
                        /*If so adding to the field*/
                        else
                        {
                            farm.NaturalFields[choice - 1].AddResource(plant);
                            Planted = true;
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


