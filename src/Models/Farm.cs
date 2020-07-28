using System;
using System.Collections.Generic;
using System.Text;
using Trestlebridge.Interfaces;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Models
{
    public class Farm
    {
        public List<GrazingField> GrazingFields { get; } = new List<GrazingField>();
        public List<PlowedField> PlowedFields { get; } = new List<PlowedField>();

        public List<NaturalField> NaturalFields { get; } = new List<NaturalField>();

        public List<ChickenHouse> ChickenHouses { get; } = new List<ChickenHouse>();

        public List<DuckHouse> DuckHouses { get; } = new List<DuckHouse>();

        /*
            This method must specify the correct product interface of the
            resource being purchased.
         */
        public void PurchaseResource<T>(IResource resource, int index)
        {
            Console.WriteLine(typeof(T).ToString());
            switch (typeof(T).ToString())
            {
                case "Cow":
                    GrazingFields[index].AddResource((IGrazing)resource);
                    break;
                default:
                    break;
            }
        }

        public void AddGrazingField(GrazingField field)
        {
            GrazingFields.Add(field);
            Console.WriteLine("Grazing Field has been added");
            Console.WriteLine("Press enter key to continue");
            Console.ReadLine();
        }

        public void AddChickenHouse(ChickenHouse field)
        {
            ChickenHouses.Add(field);
            Console.WriteLine("Chicken House has been added");
            Console.WriteLine("Press enter key to continue");
            Console.ReadLine();
        }

        public void AddNaturalField(NaturalField field)
        {
            NaturalFields.Add(field);
            Console.WriteLine("Natural Field has been added");
            Console.WriteLine("Press enter key to continue");
            Console.ReadLine();
        }

        public void AddDuckHouse(DuckHouse field)
        {
            DuckHouses.Add(field);
            Console.WriteLine("Duck House has been added");
            Console.WriteLine("Press enter key to continue");
            Console.ReadLine();
        }

        public void AddPlowedField(PlowedField field)
        {
            PlowedFields.Add(field);
            Console.WriteLine("Plowed field has been created");
            Console.WriteLine("Press enter key to continue");
            Console.ReadLine();
        }

        public override string ToString()
        {
            StringBuilder report = new StringBuilder();

            GrazingFields.ForEach(gf => report.Append(gf));
            ChickenHouses.ForEach(ch => report.Append(ch));

            return report.ToString();
        }
    }
}