namespace StringManipulation
{
    internal class Program
    {
       
           public static void Main(string[] args)

            {
            Console.WriteLine("String Manipulation Example");

            if (args.Length == 0)
                {
                    Console.WriteLine("Please pass the string as an argument in format: Name,Company,Location");
                    return;
                }

                string input = args[0];

                string[] parts = input.Split(',');

                if (parts.Length != 3)
                {
                    Console.WriteLine("Invalid input. Please pass string in format: Name,Company,Location");
                    return;
                }

                string developerName = parts[0];
                string companyName = parts[1];
                string location = parts[2];

                Console.WriteLine($"Developer name is : {developerName}");
                Console.WriteLine($"Company name is : {companyName}");
                Console.WriteLine($"Locaiton is : {location}");
            }
        }
    }
