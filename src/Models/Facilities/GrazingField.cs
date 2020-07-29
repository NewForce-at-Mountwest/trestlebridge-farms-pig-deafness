using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities {
    public class GrazingField : IFacility<IGrazing>
    {
        /*Field capacity*/
        private int _capacity = 20;
        private Guid _id = Guid.NewGuid();
        /*Current number of animals in the field*/
        public int currentNumberInField;

        private List<IGrazing> _animals = new List<IGrazing>();

        public double Capacity {
            get {
                return _capacity;
            }
        }

        public void AddResource (IGrazing animal)
        {
            /*Adding the animal to the list*/
            _animals.Add(animal);
            /*Incrementing the number in field variable*/
            currentNumberInField += 1;
            /*Showing current number of animals in the field*/
            Console.WriteLine(currentNumberInField);
            Console.WriteLine();

        }

        public void AddResource (List<IGrazing> animals) 
        {
            // TODO: implement this...
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Grazing field {shortId} has {this._animals.Count} animals\n");
            this._animals.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}