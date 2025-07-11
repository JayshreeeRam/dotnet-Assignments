namespace EmployeeStruct
{
    public struct Employee
    {
        public int Id;
        public string Name;
        public int Salary;
        public static int count;

        public Employee(int id, string name, int salary)
        {
            Console.WriteLine("parameterized constructor of struct");
            this.Id = id;
            this.Name = name;
            this.Salary = salary;
        }

        public Employee(int id, string name)
        {
            Console.WriteLine("other parameterized constructor of struct");
            this.Id = id;
            this.Name = name;
        }

        public void Display()
        {
            Console.WriteLine($"display kero!\nid: {this.Id} name: {this.Name}");
        }

        public static void EmpCount()
        {
            count++;
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(101,"manish");
           employee.Display();
            Console.WriteLine("Hello, World!");
        }
    }
}
