using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudList
{
    public class Student
    {
        public int RollNo;
        public string Name;
        public double Marks;

        public void Display()
        {
            Console.WriteLine($"Roll No: {RollNo}, Name: {Name}, Marks: {Marks}");
        }
    }
}