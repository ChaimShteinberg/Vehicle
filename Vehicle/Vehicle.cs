using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    public abstract class Vehicle
    {
        public Vehicle(string model)
        {
            this.model = model;
        }
        protected string model;

        public abstract void Drive();

        public string GetModel()
        {
            if (model.Length > 0)
            {
                return this.model;
            }
            return "not model";
        }

        public void ChangeModel(string model)
        {
            this.model = model;
        }
    }

    interface IRefuelable
    {
        void Refuel();
    }

    public class Truck : Vehicle, IRefuelable
    {
        public Truck(string model):base (model)
        {
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

    public class Motorcycle: Vehicle, IRefuelable
    {
        public Motorcycle(string model)
        {
            this.model = model;
        }

        public override void Drive()
        {
            Console.WriteLine("The motorcycle is driving.");
        }

        public void Refuel()
        {
            Console.WriteLine("Fueling the motorcycle");
        }
    }

    public class Car: Vehicle, IRefuelable
    {
        public Car(string model)
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
