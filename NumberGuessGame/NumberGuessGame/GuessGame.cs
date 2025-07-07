using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessGame
{
    internal class GuessGame
    {
        private int _numberToGuess;
        private int _maxAttempts;
        private int _currentAttempt;

       
        public GuessGame(int maxAttempts = 5)
        {
            _maxAttempts = maxAttempts;
            ResetGame();
        }

        
        public void ResetGame()
        {
            Random random = new Random();
            _numberToGuess = random.Next(1, 101); 
            _currentAttempt = 0;
        }

      
        public string MakeGuess(int guess)
        {
            _currentAttempt++;

            if (guess < 1 || guess > 100)
            {
                return "Please guess a number between 1 and 100.";
            }

            if (guess == _numberToGuess)
            {
                return " Congratulations! You've guessed the number!";
            }
            else if (_currentAttempt >= _maxAttempts)
            {
                return $"Sorry, you've used all your attempts. The number was {_numberToGuess}.";
            }
            else if (guess < _numberToGuess)
            {
                return "Too low! Try again.";
            }
            else
            {
                return "Too high! Try again.";
            }
        }
    }
}