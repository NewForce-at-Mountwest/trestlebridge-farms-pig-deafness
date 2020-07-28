using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Facilities
{
    public class PlowedField :IFacility<ISeedProducing>
    {
        public double Capacity { get; }
        public void AddResource(ISeedProducing resource)
        {
            /*Adds seed?*/
        }

        public void AddResource(List<ISeedProducing> resources)
        {
            /*List of resources*/
        }
    }
}