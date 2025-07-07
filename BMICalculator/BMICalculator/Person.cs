using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{
    
        class Person
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public double Height { get; set; }  
            public double Weight { get; set; } 

            public Person(int id, string name, int age, double height, double weight)
            {
                Id = id;
                Name = name;
                Age = age;
                Height = height;
                Weight = weight;
            }

            public Person(int id, string name, int age)
            {
                Id = id;
                Name = name;
                Age = age;
                Height = 5.0;
                Weight = 50.0;
            }

            public double CalculateBMI()
            {
               
                double heightMeters = Height * 0.3048;
                return Weight / (heightMeters * heightMeters);
            }

          
        public string GetBodyType()
            {
                double bmi = CalculateBMI();
                if (bmi < 18.5)
                    return "Underweight";
                else if (bmi >= 18.5 && bmi < 25)
                    return "Normal weight";
                else if (bmi >= 25 && bmi < 30)
                    return "Overweight";
                else
                    return "Obese";
            }

            public override string ToString()
            {
                return $"Id: {Id}, Name: {Name}, Age: {Age}, Height: {Height} ft, Weight: {Weight} kg";
            }
        }
    }


