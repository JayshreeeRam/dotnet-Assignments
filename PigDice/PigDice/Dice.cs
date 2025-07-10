using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigDice
{
    internal class Dice
    {
        public static int DiceValue()
        {
            Random rand = new Random();
            return Convert.ToInt32(rand.Next(1, 10));
        }
        public static void startGame()
        {
            int value = 0, totalValue = 0, turn = 3;
            int diceVal = 0;
            int target = 20;
            Console.WriteLine("Turn");
            while (turn > 0)
            {

                Console.WriteLine("Do you want to roll or Hold");
                Console.WriteLine("Press r for roll and h for hold");

                string input = Console.ReadLine();
                if (input != null)
                {
                    Console.WriteLine("You entered: " + input);

                    if (input == "h")
                    {

                        totalValue += value;
                        value = 0;
                        turn--;
                        Console.WriteLine("Total Value: " + totalValue);
                        Console.WriteLine("Turn Value: " + value);
                        Console.WriteLine("Total Turn Left: " + turn);
                    }

                    if (input == "r")
                    {
                        diceVal = DiceValue();
                        Console.WriteLine("Dice Value: " + diceVal);
                        if (diceVal == 1)
                        {
                            value = 0;
                            turn--;
                            Console.WriteLine("Total Value: " + totalValue);
                            Console.WriteLine("Turn Value: " + value);
                            Console.WriteLine("Total Turn Left: " + turn);
                        }
                        else
                        {
                            value += diceVal;
                        }

                    }


                }
            }

            if (totalValue >= target)
            {
                Console.WriteLine("You Win");

            }
            else
            {
                Console.WriteLine("You Lost");
            }
        }


    }
}
