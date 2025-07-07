namespace PalindromeString
{
    internal class Program
    {
        public static bool IsPalindrome(string input)
        {
            if (string.IsNullOrEmpty(input))
                return false;
            int left = 0;
            int right = input.Length - 1;
            while (left < right)
            {
                if (input[left] != input[right])
                    return false;
                left++;
                right--;
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name to check the string is Palindrome or not");
            string input = Console.ReadLine();
            if (IsPalindrome(input))
            {
                Console.WriteLine("The string is a palindrome.");
            }
            else
            {
                Console.WriteLine("The string is not a palindrome.");
            }

        }
    }
}
