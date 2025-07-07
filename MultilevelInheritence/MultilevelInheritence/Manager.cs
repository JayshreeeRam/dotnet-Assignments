using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilevelInheritence
{
    internal class Manager:Employee
    {
        public string Department { get; set; }
        
        public void DisplayManagerInfo()
        {
            Console.WriteLine($"Manager of Department: {Department}");
            DisplayEmployeeInfo();
        }
        
        public void AssignTask(string task)
        {
            Console.WriteLine($"Task '{task}' assigned to the team.");
        }
    }
}
