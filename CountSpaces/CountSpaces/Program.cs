namespace CountSpaces
{
    internal class Program
    {
        public static int CountSpaces(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }
            int spaceCount = 0;
            foreach (char c in input)
            {
                if (c == ' ')
                {
                    spaceCount++;
                }
            }
            return spaceCount;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the sentence to check the space");
            string input = Console.ReadLine();  
            int ans= CountSpaces(input);
            Console.WriteLine($"The number of spaces in the sentence is: {ans}");
        }
    }
}
