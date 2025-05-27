using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    internal class Car : Vehicle, IRefuelable
    {
        public Car(string model) : base(model)
        {
            this.model = model;
        }

        public override void Drive()
        {
            Console.WriteLine("The car is driving.");
        }

        public void Refuel()
        {
            Console.WriteLine("Fueling the car");
        }
    }
}
