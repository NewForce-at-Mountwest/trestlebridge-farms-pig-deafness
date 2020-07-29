using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities
{
    public class NaturalField : IFacility<IResource>
    {

        public int Rows { get; set; } = 10;
        public int Plants { get; set; } = 6;

        public Double Capacity
        {
            get
            {
                return Rows * Plants;
            }
        }
        private List<IResource> _plants = new List<IResource>();


        public void AddResource(List<IResource> plants)
        {

        }

       
        public void AddResource(IResource plant)
        {
            _plants.Add(plant);
        }

    }
    }

        

       

