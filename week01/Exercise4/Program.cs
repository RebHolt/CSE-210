using System;

class Program
{
    static void Main(string[] args)
    {
        string userInput;
        float userNumber;

        float currentHighest = 0;
        float sum = 0;
        float average;

        List<float> numbers = new List<float>();        // create new list

        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        do      // -- list writing loop --
        {
            Console.Write("\tEnter number: ");
            userInput = Console.ReadLine();             // get input
            userNumber = float.Parse(userInput);        // convert to float

            if (userNumber != 0)                        // don't add 0 to the list
            {
                numbers.Add(userNumber);                // add number to list
            }
        } while (userNumber != 0);                      // until user entered 0

        // -- find highest num and add up all numbers --
        foreach (float num in numbers)
        {
            sum += num;                          // add all numbers together (for sum, obviously)
            if (num > currentHighest)            // keep track of current highest (for maximum)
            {
                currentHighest = num;
            }
        }

        average = sum / numbers.Count();                // calculate average

        // -- print answers --
        Console.WriteLine($"Sum --------- {sum}\n" +
                          $"Average ----- {average}\n" +
                          $"Largest ----- {currentHighest}\n");

    }
}