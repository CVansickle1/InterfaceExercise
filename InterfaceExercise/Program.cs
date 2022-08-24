using System;
using System.Collections.Generic;
using InterfaceExercise;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            var car = new Car()
            {
                Convertable = true,
                Name = "Honda",
                Wheels = 4,
                TrunkSize = "Small",
                Slogan = "The Power Of Dreams",
                Cylinders = 4,
                IsElectric = false,
                Model = "Civic"
            };

            Truck truck = new Truck()
            {
                BedSize = "Large",
                IsElectric = true,
                Wheels = 4,
                Slogan = "Built Ford Tough",
                Name = "Ford",
                Cylinders= 0,
                Model = "Lightning",
                CoveredBed = false

            };

            var suv = new SUV()
            {
                TowHook = true,
                IsElectric = true,
                Wheels= 4,
                Slogan = "Find New Roads",
                Name = "Chevy",
                Cylinders = 0,
                Model = "Bolt",
                DVDPlayer = false
            };

            var vehicleList = new List<IVehicle>();
            vehicleList.Add(suv);
            vehicleList.Add(car);
            vehicleList.Add(truck);

            foreach(var item in vehicleList)
            {
                item.Explanation();
                Console.WriteLine();

            }




        }
    }
}
