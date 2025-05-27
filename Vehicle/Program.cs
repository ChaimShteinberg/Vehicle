using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Truck myTruck = new Truck("a");
            Console.WriteLine(myTruck.GetModel());
        }
    }
}
