using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Interface
{
    public abstract class Vehicle : IVehicle
    {
        public string Brand { get; set; }

        public Vehicle(string brand)
        {
            Brand = brand;
        }

        public abstract void Start();
        public abstract void Stop();

        public void DIsplayBrand()
        {
            Console.WriteLine("Brand: " + Brand);
        }
    }
}
