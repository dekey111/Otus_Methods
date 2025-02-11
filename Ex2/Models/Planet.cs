using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Models
{
    public class Planet
    {
        public string Name { get; set; }
        public int OrderNumber { get; set; }
        public double EquatorLength { get; set; }
        public string PreviousPlanet { get; set; }

        public Planet(string name, int ordernum, double equatorLength, string previousPlanet)
        {
            Name = name;
            OrderNumber = ordernum;
            EquatorLength = equatorLength;
            PreviousPlanet = previousPlanet;
        }
    }
}
