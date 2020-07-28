using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Facilities
{
    public class DuckHouse : IFacility<IResource>
    {
        private int _capacity = 12;
        private Guid _id = Guid.NewGuid();

        public double Capacity {
            get {
                return _capacity;
            }
        }

        double IFacility<IResource>.Capacity => throw new NotImplementedException();

        public void AddResource(IResource resource)
        {
            throw new NotImplementedException();
        }

        public void AddResource(List<IResource> resources)
        {
            throw new NotImplementedException();
        }
    }
}