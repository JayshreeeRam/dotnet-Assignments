namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int n=Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            for(int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            Console.WriteLine($"Factorial of {n} is {fact}");
        }
    }
}
