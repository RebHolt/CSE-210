using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        bool correct = false;
        string playAgain = "y";
        string userInput;

        // string response;
        Random randomGenerator = new Random();

        while (playAgain == "y")
        {
            Console.WriteLine("\nGuess the Number from 1 to 100!");

            int magicNum = randomGenerator.Next(1, 101);
            int numberOfGuesses = 0;
            do
            {
                Console.Write("  > ");

                userInput = Console.ReadLine();
                int guess = int.Parse(userInput);
                numberOfGuesses++;


                if (magicNum == guess)
                {
                    Console.WriteLine($"Congratulations! You Won! \n Number of guesses: {numberOfGuesses}");
                    correct = true;
                }
                else if (magicNum > guess)
                {
                    Console.WriteLine("Higher");
                    correct = false;
                }
                else if (magicNum < guess)
                {
                    Console.WriteLine("Lower");
                    correct = false;
                }
            } while (correct == false);

            Console.WriteLine("Play again? (y/n)");
            Console.Write("  > ");
            playAgain = Console.ReadLine();
        }
    }
}