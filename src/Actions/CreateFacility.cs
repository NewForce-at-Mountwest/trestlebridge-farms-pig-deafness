using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions {
    public class CreateFacility {
        public static void CollectInput (Farm farm) {
            Console.WriteLine ("1. Grazing field");
            Console.WriteLine ("2. Plowed field");

            Console.WriteLine ();
            Console.WriteLine ("Choose what you want to create");

            Console.Write ("> ");
            string input = Console.ReadLine ();

            switch (Int32.Parse(input))
            {
                case 1:
                    farm.AddGrazingField(new GrazingField());
                    Console.WriteLine("Field has been created");
                    break;
                case 2:
                    /*farm.AddPlowedField*/
                    break;
                case 3:
                    /*farm.AddNaturalField*/
                    break;
                case 4:
                    /*farm.AddChickenHouse*/
                    break;
                case 5:
                    /*farm.AddDuckHouse*/
                    break;
                default:
                    break;
            }
        }
    }
}