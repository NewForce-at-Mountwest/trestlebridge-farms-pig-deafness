using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Facilities
{
    public class PlowedField :IFacility<IResource>
    {
        /*Number of rows in the field*/
        private static int Rows = 13;
        /*Number of plants per row*/
        private static int Plants = 5;
        /*Total capacity of the field*/
        public double Capacity => Rows * Plants;

        public void AddResource(IResource resource)
        {
            /*Placeholder*/
        }

        public void AddResource(List<IResource> resources)
        {
            /*throw new System.NotImplementedException();*/
        }
    }
}