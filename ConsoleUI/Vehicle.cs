using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public int Year { get; set; } = 1;
        public string Make { get; set; } = "Default Make";
        public string Model { get; set; } = "Default Model";

        public abstract void DriveAbstract(); //stubbed out method; no implementation
           

        public virtual void DriveVirtual() // has implementation; has scope
        {
            Console.WriteLine("Let's take a virtual test drive!");
        }

        


    }
}
