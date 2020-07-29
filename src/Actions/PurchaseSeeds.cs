using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Plants;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions {
    public class PurchaseSeeds {
        public static void CollectInput (Farm farm) {
            Console.WriteLine ("1. Sesame");
            Console.WriteLine ("2. SunFlower");
            Console.WriteLine ("3. WildFlower");

            Console.WriteLine ();
            Console.WriteLine ("What are you buying today?");

            Console.Write ("> ");
            string choice = Console.ReadLine ();

            switch (Int32.Parse(choice))
            {
                // case 1:
                //     ChoosePlantingField.CollectSeedPlantInput(farm, new Sesame());
                //     break;
                // case 2:
                //     ChoosePlantingField.CollectSeedPlantInput(farm, new SunFlower());
                //     break;
                case 3:
                    ChoosePlantingField.CollectCompostPlantInput(farm, new SunFlower());
                    break;
                case 4:
                    ChoosePlantingField.CollectCompostPlantInput(farm, new WildFlower());
                    break;
                default:
                    break;
            }
        }
    }
}