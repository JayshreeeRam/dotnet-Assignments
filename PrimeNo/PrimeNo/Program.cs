using System;
class Prime
{
    public static void Main(string[] Args)
    {
        Console.WriteLine("Enter a number to check if it is prime:");
        int n = Convert.ToInt32(Console.ReadLine());
        bool isPrime = false;
        if (n <= 1)
        {
            Console.WriteLine("No it is not a prime");
            return;
        }
        else
        {
            for (int i = 2; i * i <= n; ++i)
            {
                if (n % i == 0)
                {
                    isPrime = false;

                    break ;
                }

            }
            if (isPrime == false)
            {
                Console.WriteLine("No it is not a prime");
            }
            else
            {
                Console.WriteLine("Yes it is a prime");
            }
        }


        
    }
}