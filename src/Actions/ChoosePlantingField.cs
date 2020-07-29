using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Plants;

namespace Trestlebridge.Actions
{
    public class ChoosePlantingField
    {
        public static void CollectInput(Farm farm, <T> plant)
        {
            Utils.Clear();

            for (int i = 0; i < farm.NaturalFields.Count; i++)
            {
                // if(i > 0){
                Console.WriteLine($"{i + 1}. Natural Field");
                // if(farm.PlowedFields.Count > 0){

            }

            for (int j = 0; j < farm.PlowedFields.Count; j++)
            {
                Console.WriteLine($"{farm.NaturalFields.Count + j + 1}. Plowed Field");
            }

            Console.WriteLine();

            // How can I output the type of animal chosen here?
            Console.WriteLine($"Plant the seeds where?");

            Console.Write("> ");
            int choice = Int32.Parse(Console.ReadLine());

            farm.NaturalFields[choice - 1].AddResource(plant);
            Console.WriteLine("Plant added to field");
            Console.ReadLine();

        }
    }
}
