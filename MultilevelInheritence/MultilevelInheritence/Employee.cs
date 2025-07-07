using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilevelInheritence
{
    internal class Employee:Person
    {
        public int EmployeeId { get; set; }
        public void DisplayEmployeeInfo()
        {
            Console.WriteLine($"Employee ID: {EmployeeId}");
            DisplayInfo();
        }
    }
}
