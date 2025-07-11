using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Rectangle:IPolygon, IColor
    {
    public void CalculateArea()
    {
        Console.WriteLine("Area is length *Breadth");
    }
    public void DisplaySides()
    {
        Console.WriteLine("Rectangle has 4 sides");
    }

    public void setColor(string color)
    {
        Console.WriteLine($"Rectangle is of {color} color");
    }

    }
}
