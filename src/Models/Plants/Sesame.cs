using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants
{
    public class Sesame : IResource, ISeedProducing
    {
        private int _seedsProduced = 40;
        Guid _id = new Guid();
        private string _shortId {
            get {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }
        public string Type { get; } = "Sesame";

        public double Harvest () {
            return _seedsProduced;
        }

        public override string ToString () {
            return $"Sesame. Yum!";
        }
    }
}