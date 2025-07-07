namespace SingleInheritence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Single Inheritence");

            Console.WriteLine("Enter Id");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Department");
            string department = Console.ReadLine();
            Console.WriteLine("Enter Team");
            string team = Console.ReadLine();
           
            Manager manager = new Manager(id, name, department, team);
            manager.DisplayManagerInfo();
        }
    }
}
