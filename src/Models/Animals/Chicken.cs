using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals {
    public class Chicken : IResource, IMeatProducing, IEggProducing, IFeatherProducing
    {
        private Guid _id = Guid.NewGuid();
        private double _meatProduced = 1.7;
        private int _eggsProduced = 7;
        private double _feathersProduced = 0.5;
        private string _shortId {
            get {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }
        public double FeedPerDay { get; set; } = 0.9;
        public string Type { get; } = "Chicken";

        // Methods
        public double Butcher()
        {
            return _meatProduced;
        }
        
        public override string ToString () {
            return $"Chicken {this._shortId}. Cluck!";
        }

        public double EggCollection()
        {
            return _eggsProduced;
        }

        public double FeathersCollected()
        {
            return _feathersProduced;
        }
    }
}