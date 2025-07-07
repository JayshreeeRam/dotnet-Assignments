using System;
using System.Collections.Generic;

namespace PlanetWeightCalculator
{
    enum Planet
    {
        MERCURY,
        VENUS,
        EARTH,
        MARS,
        JUPITER,
        SATURN,
        URANUS,
        NEPTUNE
    }

    class Program
    {
        static void Main(string[] args)
        {
             Dictionary<Planet, double> planetGravity = new Dictionary<Planet, double>()
            {
                { Planet.MERCURY, 0.38 },
                { Planet.VENUS, 0.91 },
                { Planet.EARTH, 1.00 },
                { Planet.MARS, 0.38 },
                { Planet.JUPITER, 2.36 },
                { Planet.SATURN, 0.92 },
                { Planet.URANUS, 0.89 },
                { Planet.NEPTUNE, 1.13 }
            };

            Console.Write("Enter your weight on Earth (kg): ");
            if (double.TryParse(Console.ReadLine(), out double earthWeight))
            {
                Console.WriteLine();
                foreach (Planet planet in Enum.GetValues(typeof(Planet)))
                {
                    if (planet == Planet.EARTH) continue; 

                    double equivalentWeight = earthWeight * planetGravity[planet];
                    Console.WriteLine($"Weight on {planet}: {equivalentWeight:F1} kg");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }
}
