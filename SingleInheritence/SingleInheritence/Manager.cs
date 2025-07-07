using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleInheritence
{
    internal class Manager:Employee
    {
        public string Team { get; set; }
        public Manager(int id, string name, string department, string team) : base(id, name, department)
        {
            Team = team;
        }
        public void DisplayManagerInfo()
        {
            DisplayInfo();
            Console.WriteLine($"Team: {Team}");
        }
    }
}
