using System;
using System.Collections.Generic;
using System.Text;

namespace taksi
{
    class Objek
    {
        string nama;
        int nomor;
        int duty;

        public void DriverName()
        {
            Console.WriteLine("Driver Name : Jono");
        }

        public void OnDuty()
        {
            Console.WriteLine("On Duty : Yes");
        }

        public void NumberOfPpassenger()
        {
            Console.WriteLine("Number Of Passenger : 10");
        }

        public void PickUpPassenger()
        {
            Console.WriteLine("Jono Sedang Menjemput Penumpang");
        }

        public void DropOffPasengger()
        {
            Console.WriteLine("Jono Sedang Mengantar Penumpang");
        }


    }
}
