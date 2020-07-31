using System;
using System.Collections.Generic;
using System.Text;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Facilities
{
    public class PlowedField : IFacility<ISeedProducing>
    {
        private Guid _id = Guid.NewGuid();

        /*Number of rows in the field*/
        private static int Rows = 13;
        /*Number of plants per row*/
        private static int Plants = 5;
        /*Total capacity of the field*/
        public double Capacity => Rows * Plants;

        public int currentNumberInField;

        private List<ISeedProducing> _plants = new List<ISeedProducing>();
        public void AddResource(ISeedProducing plant)
        {
            /*Adding the animal to the list*/
            _plants.Add(plant);
            /*Incrementing the number in field variable*/
            currentNumberInField += 1;
            /*Showing current number of animals in the field*/
            Console.WriteLine(currentNumberInField);
            Console.WriteLine();

        }

        public void AddResource(List<ISeedProducing> plants)
        {
            // TODO: implement this...
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Plowed field {shortId} has {this._plants.Count} plants\n");
            this._plants.ForEach(p => output.Append($"   {p}\n"));

            return output.ToString();
        }

    }

}
