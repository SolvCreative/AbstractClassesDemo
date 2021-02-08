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

            #region Vehicles


            
            var vehicles = new List<Vehicle>();

           
            Car focus = new Car() { HasTrunk = true, Make = "Ford", Model = "focus", Year = 2013 };

            Motorcycle harley = new Motorcycle() { HasSideCart = false, Make = "Harley Davidson", Model = "Silver Beast", Year = 2019 };

            Vehicle sedan = new Car() { HasTrunk = true, Make = "Dodge", Model = "Intrepid", Year = 2002 };

            Vehicle sport = new Car() { HasTrunk = true, Make = "Chevy", Model = "Corvette", Year = 1984 };

            vehicles.Add(focus);
            vehicles.Add(harley);
            vehicles.Add(sedan);
            vehicles.Add(sport);

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Make {vehicle.Make} Model {vehicle.Model} Year {vehicle.Year}");
                vehicle.DriveAbstract();
                Console.WriteLine("__________________________________");
            }

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
