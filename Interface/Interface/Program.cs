namespace Interface
{
    internal class Program
    {
        public static void AskUser()
        {
            Console.WriteLine("Do you want Rectangle or circle");
            string choice = Console.ReadLine();

            if (choice == "circle")
            {
                Circle circle = new Circle();
                circle.CalculateArea();
                circle.DisplaySides();
                circle.setColor("Yellow");
            }
            else
            {
                Rectangle rectangle = new Rectangle();
                rectangle.CalculateArea();
                rectangle.DisplaySides();
                rectangle.setColor("red");
            }
        }
        static void Main(string[] args)
        {
            AskUser();
        }
    }
}
