using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zajecia2
{
    interface ISamochod
    {
         void WypiszMarke();
         void WypiszSalon();
    }

    class AstonMartin : ISamochod
    {
        public void WypiszMarke()
        {
            Console.WriteLine("Marka to AstonMartin");
        }
        public void WypiszSalon()
        {
            Console.WriteLine("Salon to AstonMartin");
        }
    }

    class RollsRoyce : ISamochod
    {
        public void WypiszMarke()
        {
            Console.WriteLine("Marka to RollsRoyce");
        }
        public void WypiszSalon()
        {
            Console.WriteLine("Salon to RollsRoyce");
        }
    }
    class RangeRover : ISamochod
    {
        public void WypiszMarke()
        {
            Console.WriteLine("Marka to Range Rover");
        }
        public void WypiszSalon()
        {
            Console.WriteLine("Salon to Range Rover");
        }
    }
   


    class Program
    {
        static void Main(string[] args)
        {
            RangeRover auto = new RangeRover();
            auto.WypiszMarke();
            auto.WypiszSalon();
            Console.ReadLine();
        }
    }
}
