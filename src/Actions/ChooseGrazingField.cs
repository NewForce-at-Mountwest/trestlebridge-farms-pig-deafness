using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
    public class ChooseGrazingField
    {
        public static void CollectInput(Farm farm, IGrazing animal)
        {
            Utils.Clear();
            /*Creating a bool for breaking the while loop*/
            bool Placed = false;
            while (Placed == false)
            {
                /*Loop for printing fields with if for seeing if full*/
                for (int i = 0; i < farm.GrazingFields.Count; i++)
                {
                    Console.WriteLine(farm.GrazingFields[i].Capacity == farm.GrazingFields[i].currentNumberInField
                        ? $"{i + 1}. Grazing Field (Full)"
                        : $"{i + 1}. Grazing Field ({farm.GrazingFields[i].currentNumberInField} animals)");
                }

                Console.WriteLine();

                /*Asking where to place the animal by type/name i.e. cow*/
                Console.WriteLine($"Place the {animal.GetType().Name} where?");

                Console.Write("> ");
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
                        farm.GrazingFields[choice -1].AddResource(animal);
                        Placed = true;
                        Console.WriteLine("Break Point");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Please enter only numbers");
                }
                
            }
            

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);

        }
    }
}