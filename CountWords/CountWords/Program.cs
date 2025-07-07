namespace CountWords
{
    internal class Program
    {
        public static int CountWordsInString(string input)
        {
            int count = 0;
            if (string.IsNullOrWhiteSpace(input))
            {
                return 0;
            }
            for(int i = 0; i < input.Length; i++)
            {
                if (char.IsLetterOrDigit(input[i]) || input[i] == '_')
                {
                    if (i == 0 || !char.IsLetterOrDigit(input[i - 1]) && input[i - 1] != '_')
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name to check the count");
            string input = Console.ReadLine();
            int wordCount = CountWordsInString(input);
            Console.WriteLine($"The number of words in the input string is: {wordCount}");
        }
    }
}
