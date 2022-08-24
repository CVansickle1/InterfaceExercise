using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace InterfaceExercise
{
    internal interface IVehicle : ICompany
    {
        public int Wheels { get; set; }

        public bool IsElectric { get; set; } 

        public int Cylinders { get; set; }

        public string Model { get; set; }

        public void Explanation();

        public string Electric();
        
    }
}
