using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int number = rand.Next(20, 80);
            int lowerBound = rand.Next(number - 10, number - 2);
            int upperBound = rand.Next(number + 1, number + 10);
            int triesCount = 3;
            string userInput;

            Console.WriteLine("Welcome to the game GuessNumber! ");
            Console.WriteLine("Press any key to start the game!");
            Console.ReadKey();
            Console.WriteLine($"Try to guess the number between {lowerBound} and {upperBound}." +
                $" You have {triesCount} tries. Type 'exit' to quit the game.");

            while (true)
            {
                Console.Write("Enter your guess: ");
                userInput = Console.ReadLine();

                if (userInput.ToLower() == "exit")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }

                if (int.TryParse(userInput, out int guess))
                {

                    if (guess < lowerBound || guess > upperBound )
                    {
                        Console.WriteLine("Your answer is not in range.");
                    }
                    else if (guess == number)
                    {
                        Console.WriteLine($"Congratulations! You won! The correct answer was: {number}");
                        break;
                    }
                    else
                    {
                        triesCount--;
                        Console.WriteLine($"Your answer is wrong! You have {triesCount} tries" +
                            $" Please, try again!");
                    }
                    if (triesCount <= 0)
                    {
                        Console.WriteLine($"You lost the game! Correct answer was: {number}");
                        break;
                    }
                   
                }
                else
                {
                    Console.WriteLine("Please enter a valid number or 'exit'.");
                }
            }
           
        }
    }
}
