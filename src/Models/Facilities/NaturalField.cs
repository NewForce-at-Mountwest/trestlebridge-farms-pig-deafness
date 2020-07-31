using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities
{
    public class NaturalField : IFacility<ICompostProducing>
    {
        private Guid _id = Guid.NewGuid();
        public int Rows { get; set; } = 10;
        public int Plants { get; set; } = 6;

        public Double Capacity
        {
            get
            {
                return Rows * Plants;
            }
        }




        //Current number of plants in the field




        public int currentNumberInField;

        private List<ICompostProducing> _plants = new List<ICompostProducing>();

        public void AddResource(ICompostProducing plant)
        {
            _plants.Add(plant);
            currentNumberInField += 1;
            Console.WriteLine(currentNumberInField);
            Console.WriteLine();
        }

        public void AddResource(List<ICompostProducing> plants)
        {

        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Natural field {shortId} has {this._plants.Count} plants\n");
            this._plants.ForEach(p => output.Append($"   {p}\n"));

            return output.ToString();
        }

    }
}





