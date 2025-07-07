namespace MultilevelInheritence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multilevel Inheritence");
            Console.WriteLine("Enter Name of the Person:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Employee ID:");
            int employeeId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Department of the Manager:");
            string department = Console.ReadLine();
            Console.WriteLine("Enter Task to assign:");
            string task = Console.ReadLine();

            Manager manager= new Manager
            {
                Name = name,
                EmployeeId = employeeId,
                Department = department,

            };

            manager.DisplayInfo();
            manager.DisplayEmployeeInfo();
            manager.DisplayManagerInfo();
            manager.AssignTask(task);
        }
    }
}
