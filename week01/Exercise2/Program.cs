using System;
using System.Reflection;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            string letter = "";
            string gradeSymbol = "";
            int modulo = 0;

            // get user input
            Console.WriteLine("Please enter your grade percentage: ");
            Console.Write("  > ");
            string userInput = Console.ReadLine();
            int grade = int.Parse(userInput);

            modulo = grade % 10;

            //grade symbol
            if (modulo >= 7)
            {
                gradeSymbol = "+";
            }
            else if (modulo < 3)
            {
                gradeSymbol = "-";
            }

            //grade calculator
            if (grade >= 90)
            {
                letter = "A";
                if (gradeSymbol == "+")     //exception (no A+)
                {
                    gradeSymbol = "";
                }

                if (grade == 100)           // 100% is not A- lol
                {
                    gradeSymbol = "";
                }
            }
            else if (grade >= 80)
            {
                letter = "B";
            }
            else if (grade >= 70)
            {
                letter = "C";
            }
            else if (grade >= 60)
            {
                letter = "D";
            }
            else if (grade < 60 && grade >= 0)
            {
                letter = "F";

                if (gradeSymbol != "")      // exception (no F+ or F-)
                {
                    gradeSymbol = "";
                }
            }

            // validity check
            if (grade > 100 || grade < 0)       //Greater than 100 or less than 0
            {
                Console.WriteLine("--Error: Invalid number-- \n");
            }
            else if (grade >= 70)
            {
                Console.WriteLine($"You passed with a {letter}{gradeSymbol}. Congratulations! \n");
            }
            else
            {
                Console.WriteLine($"You got a {letter}{gradeSymbol}. Better luck next time.");

            }

        }

    }
}