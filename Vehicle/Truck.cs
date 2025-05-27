using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    internal class Truck : Vehicle, IRefuelable
    {
        public Truck(string model) : base(model)
        {
            this.model = model;
        }

        public override void Drive()
        {
            Console.WriteLine("The truck is driving.");
        }

        public void Refuel()
        {
            Console.WriteLine("Fueling the truck");
        }
    }
}
