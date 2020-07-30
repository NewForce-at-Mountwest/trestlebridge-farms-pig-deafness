using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Facilities
{
    public class DuckHouse : IFacility<IEggProducing>
    {
        private int _capacity = 12;
        private Guid _id = Guid.NewGuid();
        public int ducksInDuckHouse;

        public double Capacity {
            get {
                return _capacity;
            }
        }

        private List<IEggProducing> _ducks = new List<IEggProducing>();

        double IFacility<IEggProducing>.Capacity => throw new NotImplementedException();

        public void AddResource(IEggProducing duck)
        {
            _ducks.Add(duck);
            ducksInDuckHouse += 1;
            Console.WriteLine(ducksInDuckHouse);
            Console.WriteLine();
        }

        public void AddResource(List<IEggProducing> resources)
        {
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