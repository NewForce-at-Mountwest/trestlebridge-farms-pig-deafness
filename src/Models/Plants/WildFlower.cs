using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants
{
    public class WildFlower : IResource, ICompostProducing
    {
        private Guid _id = Guid.NewGuid();
        private double _compostProduced = 30.3;
        public string Type { get; } = "WildFlower";

        public double Compost()
        {
            return _compostProduced;
        }

        public override string ToString () {
            return $"Wildflowers. Beautiful!";
        }
    }
}