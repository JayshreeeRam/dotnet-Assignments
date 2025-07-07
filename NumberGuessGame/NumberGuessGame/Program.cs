
namespace NumberGuessGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------Number Guess App------");
            GuessGame game = new GuessGame(5);
            Console.WriteLine("Welcome to the Number Guess Game!");

            while (true)
            {
                Console.Write("Enter your guess: ");
                if (int.TryParse(Console.ReadLine(), out int guess))
                {
                    string result = game.MakeGuess(guess);
                    Console.WriteLine(result);

                    if (result.Contains("Congratulations") || result.Contains("Sorry"))
                    {
                        Console.Write("Play again? (y/n): ");
                        string again = Console.ReadLine().ToLower();
                        if (again == "y")
                        {
                            game.ResetGame();
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("! Invalid input. Please enter a valid number.");
                }
            }

            Console.WriteLine("Thanks for playing!");
        }
    }
}