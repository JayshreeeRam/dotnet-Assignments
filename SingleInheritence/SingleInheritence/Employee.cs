using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleInheritence
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string department { get; set; }
        public Employee(int id,string name,string department) { 
            Id = id;
            Name = name;
            this.department = department;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Id: {Id}, Name: {Name}, Department: {department}");
        }
        
       
    }
}
