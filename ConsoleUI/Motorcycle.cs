using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public bool HasSideCar { get; set; }  
        public override void DriveAbstract()
        {
            Console.WriteLine("the motorcycle is driving abstract ");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine("the motorcyle is driving virtual");
        }
    } 

}
