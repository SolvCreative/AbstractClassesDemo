using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public bool HasTrunk { get; set; } = true; //gave it a default value

        public override void DriveAbstract()
        {
            Console.WriteLine("This car is in drive!");
        }
    }

}
