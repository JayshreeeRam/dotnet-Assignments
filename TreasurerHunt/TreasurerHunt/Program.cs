namespace TreasurerHunt
{
    internal class Program
    {
        public static bool Treasurer()
        {
            Console.WriteLine("Start The Game ");
            Console.WriteLine("Left or Right ");
            string input = Convert.ToString(Console.ReadLine());
            Console.WriteLine("You choose " + input);

            if (input == "right")
            {
                Console.WriteLine("Fall into a hole. Game Over ");
                return false;
            }
            else
            {
                Console.WriteLine("Well Played By taking Left Move ");
                Console.WriteLine("Swim or Wait ");
                input = Convert.ToString(Console.ReadLine());
                Console.WriteLine("You choose " + input);

                if (input == "Swim")
                {
                    Console.WriteLine("Attacked By Trout. Game Over");
                    return false;
                }
                else
                {
                    Console.WriteLine("Well Played By Waiting. Now choose Which Door you want to select ");
                    Console.WriteLine("Red or Blue or Yellow or any other color");
                    input = Convert.ToString(Console.ReadLine());

                    Console.WriteLine("You choose " + input);

                    if (input == "Red")
                    {
                        Console.WriteLine("Burned By Fire.Game Over ");
                        return false;
                    }
                    else if (input == "Yellow")
                    {
                        Console.WriteLine("Congratulations!.You Win...");
                        return true;
                    }
                    else
                    {
                        if (input == "Blue")
                        {
                            Console.WriteLine("Eaten By Beasts.Game Over ");
                            return false;
                        }
                        else
                        {
                            Console.WriteLine("Game Over ");
                            return false;
                        }


                    }

                }

            }
            return true;
        }
       public  static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Treasurer Hunt Game");
            if (Treasurer())
            {
                Console.WriteLine("You are a Winner!");
            }
            else
            {
                Console.WriteLine("Better luck next time!");
            }

        }
    }
}
