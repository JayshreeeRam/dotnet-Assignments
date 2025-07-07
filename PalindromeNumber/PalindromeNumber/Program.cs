namespace PalindromeNumber
{
    internal class Program
    {
        public static bool IsPalindrome(int a)
        {
            int temp = a;
            int n = 0;
            int digit;
            while (a > 0)
            {
                digit = a % 10;
                n = n * 10 + digit;
                a /= 10;
            }
            if (temp == n)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a number to check if it is a palindrome:");
            int number = Convert.ToInt32(Console.ReadLine());
            if (IsPalindrome(number))
            {
                Console.WriteLine($"{number} is a palindrome.");
            }
            else
            {
                Console.WriteLine($"{number} is not a palindrome.");
            }
             }
    }
}