using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class Truck : ICompany, IVehicle
    {
        public bool CoveredBed { get; set; }
        public string BedSize { get; set; }
        public string Name { get; set; }
        public string Slogan { get; set; }
        public int Wheels { get; set; }
        public bool IsElectric { get; set; }
        public int Cylinders { get; set; }
        public string Model { get; set; }
        public string Electric()
        {
            return IsElectric ? "is Electric" : $"is not Electric and has {Cylinders} cylinders";
        }

        public string Cover()
        {
            return CoveredBed ? "covered" : "not covered";
        }

        public void Explanation()
        {

            Console.WriteLine($"Im Driving my {Name}, {Model}, it {Electric()}. It also has a {BedSize} {Cover()} Bed.");
        }

    }
}
