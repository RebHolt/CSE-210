using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squared = SquareNumber(userNumber);          // Misunderstood the requirement, so I'm leaving this in lol
        int squareRoot = SquareRootNumber(userNumber);      // It's a stretch challenge I guess
        DisplayResult(userName, squared, squareRoot);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("\n--- Welcome to the Program! ---");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();

        return userName;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string userInput = Console.ReadLine();
        int favNumber = int.Parse(userInput);

        return favNumber;
    }
    static int SquareRootNumber(int favNumber)
    {
        double squaredLarge = Math.Sqrt(favNumber);
        int squaredNum = (int)Math.Round(squaredLarge);         // Casts to int (look up 'casting c#' if you forgot)

        return squaredNum;
    }

    static int SquareNumber(int userNumber)
    {
        userNumber *= userNumber;       // times by itself (square)
        return userNumber;
    }
    static void DisplayResult(string userName, int squaredNum, int squareRoot)
    {
        Console.WriteLine($"\n{userName}, the square of your number is {squaredNum}" +
                          $"\nAnd the square root of your number is {squareRoot}");
    }
}