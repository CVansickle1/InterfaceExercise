using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class Car : ICompany, IVehicle
    {
        public Car()
        {
               
        }
        
        public bool Convertable { get; set; }

        public string TrunkSize { get; set; } = "Small";
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

        public string ifConvertable()
        {
            return Convertable ? "is covertable. Pretty Cool!" : "is not convertable. Stays Dry!";
        }
        public void Explanation()
        {

            Console.WriteLine($"Im Driving my {Name}, {Model}, it {Electric()}. It also has a {TrunkSize} Trunk and {ifConvertable()}");
        }
    }
}
