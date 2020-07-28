using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals {
    public class Duck : IResource {
        
        private Guid _id = Guid.NewGuid();
        public double GrassPerDay { get; set; } = 0.8;
        public string Type { get; } = "Duck";

        // Methods
        
    }
}