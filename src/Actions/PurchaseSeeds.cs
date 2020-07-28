using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions {
    public class PurchaseSeeds {
        public static void CollectInput (Farm farm) {
            Console.WriteLine ("1. Sesame seeds");
            Console.WriteLine ("2. Wildflower seeds");
            Console.WriteLine ("3. Sunflower seeds");

            Console.WriteLine ();
            Console.WriteLine ("What are you buying today?");

            Console.Write ("> ");
            string choice = Console.ReadLine ();

            switch (Int32.Parse(choice))
            {
                case 1:
                    ChoosePlantingField.CollectInput(farm, new Sesame());
                    break;

                default:
                    break;
            }
        }
    }
}