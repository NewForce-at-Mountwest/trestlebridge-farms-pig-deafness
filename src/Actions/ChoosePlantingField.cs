using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Plants;

namespace Trestlebridge.Actions
{
    public class ChoosePlantingField
    {
        public static void CollectInput(Farm farm, IResource plant)
        {
            Utils.Clear();

            for (int i = 0; i < farm.NaturalFields.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Natural Field");
            }
            for (int j= 0; j < farm.PlowedFields.Count; j++)
            {
                Console.WriteLine($"{j + 1}. Plowed Field");
            }


            Console.WriteLine();

            // How can I output the type of animal chosen here?
            Console.WriteLine($"Plant the seeds where?");

            Console.Write("> ");
            int choice = Int32.Parse(Console.ReadLine());

            farm.NaturalFields[choice -1].AddResource(plant);

            Console.WriteLine("Plant was succesfully added to field.");
            Console.ReadLine();
            // console readline pause that plant was usccefully added

            

        }
    }
}