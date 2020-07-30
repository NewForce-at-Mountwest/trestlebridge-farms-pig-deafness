using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Plants;

namespace Trestlebridge.Actions
{
    public class ChooseSunflowerField
    {
        public static void CollectInput(Farm farm, IResource plant)
        {
            Utils.Clear();

            bool Planted = false;
            while (Planted == false)
            {
                //Loop for printing fields with if for seeing if at capacity
                for (int i = 0; i < farm.NaturalFields.Count; i++)
                {
                    Console.WriteLine(farm.NaturalFields[i].Capacity == farm.NaturalFields[i].currentNumberInField
                        ? $"{i + 1}. Natural Field (Full)"
                        : $"{i + 1}. Natural Field ({farm.NaturalFields[i].currentNumberInField} plants)");
                }
                for (int j = 0; j < farm.PlowedFields.Count; j++)
                {
                    Console.WriteLine(farm.PlowedFields[j].Capacity == farm.PlowedFields[j].currentNumberInField
                    ? $"{farm.NaturalFields.Count + j + 1}. Plowed Field (Full)"
                    : $"{farm.NaturalFields.Count + j + 1}. Plowed Field({farm.PlowedFields[j].currentNumberInField} plants)");
                }

                Console.WriteLine();

                Console.WriteLine($"Plant the {plant.GetType().Name} seeds where?");

                Console.Write("> ");

                int choice = Int32.Parse(Console.ReadLine());

                if (choice <= farm.NaturalFields.Count)
                {
                    farm.NaturalFields[choice - 1].AddResource((ICompostProducing) new SunFlower());

                    Console.WriteLine(choice);
                    Console.WriteLine("Plant added to field");
                    Console.ReadLine();
                    Planted = true;
                }
                else if (choice > farm.NaturalFields.Count)
                {
                    farm.PlowedFields[choice - farm.NaturalFields.Count - 1].AddResource((ISeedProducing) new SunFlower());
                    Console.WriteLine(choice);
                    Console.WriteLine("Plant added to field");
                    Console.ReadLine();
                    Planted = true;
                }

            }
        }
    }
}

//                 if (farm.NaturalFields[choice - 1].currentNumberInField == farm.NaturalFields[choice - 1].Capacity)
//                     {
//                         Console.WriteLine("**** That facility is not large enough ****");
//                         Console.WriteLine("****     Please choose another one      ****");
//                         choice = Int32.Parse(Console.ReadLine());
//                     }
//                     else
//                     {
//                         farm.NaturalFields[choice - 1].AddResource(plant);
//                         Console.WriteLine("Plant added to field");
//                         Console.ReadLine();

//                     }                        
//                     else if (farm.PlowedFields[choice - farm.NaturalFields.Count - 1].currentNumberInField == farm.PlowedFields[choice - farm.NaturalFields.Count -1].Capacity)
//                         {
//                             Console.WriteLine("**** That facility is not large enough ****");
//                             Console.WriteLine("****     Please choose another one      ****");
//                             choice = Int32.Parse(Console.ReadLine());
//                         }
//                         else
//                         {
//                             farm.PlowedFields[choice - farm.NaturalFields.Count - 1].AddResource(plant);
//                             //Console.WriteLine("Break Point");
//                             Console.WriteLine("Plant added to field");
//                             Console.ReadLine();
//                             Planted = true;
//                         }
//                     }

//                 }
//             }

//         }

//         }
// }