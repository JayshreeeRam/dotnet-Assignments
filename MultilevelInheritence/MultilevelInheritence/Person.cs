using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilevelInheritence
{
    internal class Person
    {
        public string Name { get; set; }
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
        }
    }
}
