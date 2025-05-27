using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    internal abstract class Vehicle
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
}
