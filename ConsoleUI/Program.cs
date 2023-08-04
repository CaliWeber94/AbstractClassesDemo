using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles
            List <string>vehicles = new List<string>();
            
                var carone = new Car();

                carone.Make = "Honda";
                carone.Model = "CRV";
                carone.Year = 2010;
                carone.HasTrunk = true;
                vehicles.Add(carone.Make);

                var motorcycleone = new Motorcycle();
                motorcycleone.Make = "BMW";
                motorcycleone.Model ="X";
                motorcycleone.Year = 1999;
                motorcycleone.HasSideCar = true;
                vehicles.Add(motorcycleone.Make);

                Vehicle cartwo = new Car();

                cartwo.Make = "Chevrolet";
                cartwo.Model = "Suburban";
                cartwo.Year = 2002;
                
                vehicles.Add(cartwo.Make);

                Vehicle motorcycletwo = new Motorcycle();
                motorcycletwo.Make = "Harley Davidson";
                motorcycletwo.Model = "Harley";
                motorcycletwo.Year = 2022;
                
                vehicles.Add(motorcycletwo.Make);


                foreach (var vehicle in vehicles)
                {
                    Console.WriteLine($"These are the current vehicles available: {vehicle}");
                }

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties with object initializer syntax
             */

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            // Call each of the drive methods for one car and one motorcycle

            motorcycleone.DriveVirtual();
            motorcycleone.DriveAbstract();
            carone.DriveAbstract();
            carone.DriveVirtual();

                #endregion
                Console.ReadLine();

            
        }
    }
}
