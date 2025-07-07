namespace BMICalculator
{
    internal class Program
    {
        public static void DisplayPersonInfo(Person p)
        {
            Console.WriteLine(p);
            double bmi = p.CalculateBMI();
            Console.WriteLine($"BMI: {bmi:F2}");
            Console.WriteLine($"Body Type: {p.GetBodyType()}");
            Console.WriteLine();
        }
       public static void Main(string[] args)
        {
            Person p1 = new Person(1, "Manish", 25, 5.5, 60);
            Person p2 = new Person(2, "Om", 30);

            DisplayPersonInfo(p1);
            DisplayPersonInfo(p2);
        }
    }
}
