using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Circle:IPolygon , IColor
    {
        public void CalculateArea()
        {
            Console.WriteLine("Area is PI*R*R");
        }
        public void DisplaySides()
        {
            Console.WriteLine("Circle has no sides");
        }

        public void setColor(string color)
        {
            Console.WriteLine($"Circle is of {color} color");
        }

    }
}
