using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants
{
    public class WildFlower : IResource, ICompostProducing
    {
        private double _compostProduced = 30.3;
        public string Type { get; } = "Wildflower";

        public double Harvest () {
            return _compostProduced;
        }

        public override string ToString () {
            return $"Wildflowers. Beautiful!";
        }
    }
}