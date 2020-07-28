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

            bool Placed = false;

            for (int i = 0; i < farm.GrazingFields.Count; i++)
            {
                Console.WriteLine(farm.GrazingFields[i].Capacity == farm.GrazingFields[i].currentNumberInField
                    ? $"{i + 1}. Grazing Field (Full)"
                    : $"{i + 1}. Grazing Field ({farm.GrazingFields[i].currentNumberInField} animals)");
            }

            Console.WriteLine();

            // How can I output the type of animal chosen here?
            Console.WriteLine($"Place the {animal.GetType().Name} where?");

            Console.Write("> ");
            int choice = Int32.Parse(Console.ReadLine());

            if (farm.GrazingFields[choice - 1].currentNumberInField == farm.GrazingFields[choice - 1].Capacity)
            {
                Console.WriteLine("**** That facility is not large enough ****");
                Console.WriteLine("****     Please choose another one      ****");
                choice = Int32.Parse(Console.ReadLine());
            }
            else
            {
                farm.GrazingFields[choice -1].AddResource(animal);
                Console.WriteLine("Break Point");
            }

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);

        }
    }
}