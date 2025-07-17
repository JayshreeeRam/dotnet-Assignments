using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Interface
{
    public class Car : Vehicle
    {
        public Car(string brand) : base(brand) { }

        public override void Start()
        {
            Console.WriteLine($"{Brand} car is starting");
        }

        public override void Stop()
        {
            Console.WriteLine($"{Brand} car is stopping");
        }
    }
}
