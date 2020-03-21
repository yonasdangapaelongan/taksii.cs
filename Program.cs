using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace taksi
{
    class Program
    {
        static void Main(string[] args)
        {
    
            Objek taksi = new Objek();

            taksi.DriverName();
            taksi.OnDuty();
            taksi.NumberOfPpassenger();

           
            taksi.PickUpPassenger();
            taksi.DropOffPasengger();

            Console.ReadKey();
            
        }
    }
}
