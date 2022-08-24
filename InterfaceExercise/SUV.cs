using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class SUV : IVehicle, ICompany
    {
        public bool TowHook { get; set; }
        
        public bool DVDPlayer { get; set; }
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

        public string CanTow()
        {
            return TowHook ? "has" : "doesnt have";
        }

        public string CanPlayMovies()
        {
            return DVDPlayer ? "can Play Movies!" : "cannot play movies";
        }

        public void Explanation()
        {

            Console.WriteLine($"Im Driving my {Name}, {Model}, it {Electric()}. It also {CanTow()} a Tow Hook, and {CanPlayMovies()}.");
        }
    }
}
