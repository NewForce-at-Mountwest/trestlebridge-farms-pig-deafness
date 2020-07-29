using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Plants;

namespace Trestlebridge.Actions
{
    public class ChooseNaturalField
    {
        public static void CollectInput(Farm farm, ICompostProducing plant)
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
                }  
                    Console.WriteLine();
                    
                    Console.WriteLine($"Plant the {plant.GetType().Name} seeds where?");

                    Console.Write("> ");

                    try
                    {
                        int choice = Int32.Parse(Console.ReadLine());
                        /*Checking to see if the field has room for the animal*/
                        if (farm.NaturalFields[choice - 1].currentNumberInField == farm.NaturalFields[choice - 1].Capacity)
                        {
                            Console.WriteLine("**** That facility is not large enough ****");
                            Console.WriteLine("****     Please choose another one      ****");
                            choice = Int32.Parse(Console.ReadLine());
                        }
                        /*If so adding to the field*/
                        else
                        {
                            farm.NaturalFields[choice - 1].AddResource(plant);
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




