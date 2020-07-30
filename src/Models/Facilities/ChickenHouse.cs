using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities {

public class ChickenHouse : IFacility<IFeatherProducing>
    {
        private int _capacity = 15;
        private Guid _id = Guid.NewGuid();
        public int chickensInChickenHouse;
        public double Capacity {
            get {
                return _capacity;
            }
        }
        private List<IFeatherProducing> _chickens = new List<IFeatherProducing>();

        public void AddResource(IFeatherProducing chicken)
        {
            _chickens.Add(chicken);
            chickensInChickenHouse += 1;
            Console.WriteLine(chickensInChickenHouse);
            Console.WriteLine();
        }

        public void AddResource(List<IFeatherProducing> resources)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Chicken House {shortId} has {this._chickens.Count} chickens\n");
            this._chickens.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }

        internal void AddResource(IEggProducing animal)
        {
            throw new NotImplementedException();
        }
    }

}