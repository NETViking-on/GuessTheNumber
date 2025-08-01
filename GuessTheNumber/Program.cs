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
            int number = rand.Next(10, 100);
            int lowerBound = rand.Next(0, number - 5);
            int upperBound = rand.Next(number + 1, number + 6);
            int triesCount = 3;
            string userInput;

            Console.WriteLine("Welcome to game GuessNumber! ");
            Console.WriteLine("Press any key to start the game!");
            Console.ReadKey();
            Console.WriteLine($"Try to guess number beetween {lowerBound} and {upperBound}." +
                $"You have {triesCount} tries.Type 'exit' to quit the game.");

            while (true)
            {
             
            }


        }
    }
}
