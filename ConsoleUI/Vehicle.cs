using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public string Make { get; set; } = "generic make";

        public string Model { get; set; } = "generic model";

        public int Year { get; set; } = 2020;

        public abstract void DriveAbstract();
                      
        public virtual void DriveVirtual()
        {
            Console.WriteLine("the vehicle is driving virtual");
        }
    }
}
