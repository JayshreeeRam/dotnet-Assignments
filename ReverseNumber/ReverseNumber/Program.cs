namespace ReverseNumber
{
    internal class Program

    {
        public static void Main(string[] Args)
        {

            Console.WriteLine("Enter a number to reverse:");
            int a = Convert.ToInt32(Console.ReadLine());
            int n = 0;
            while (a > 0)
            {
                int digit = a % 10;
                n = n * 10 + digit;
                a /= 10;
            }
            Console.WriteLine("Reversed number is: " + n);

        }
    }
}