/*
checks for any quotation marks in entry, and replaces them with double quotes
to make it compatible with csv.

asks if you want to overwrite your unsaved journal entries with the ones from the file.
also checks if you want to overwrite your save file
*/

using System;
using System.ComponentModel;
using System.Diagnostics.Tracing;
using System.IO;
using System.IO.Enumeration;
using System.Linq.Expressions;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

class Program
{
    static void Main(string[] args)
    {
        string filename;
        string userInput;
        bool doLoop = true;

        Directory.SetCurrentDirectory(@"..\..\..");     // Navigates out of \bin and into Journal

        Journal journal = new Journal();
        PromptGenerator generator = new PromptGenerator();

        Console.WriteLine("\t---Welcome to the Journal Program!---");

        while (doLoop)            // MAIN LOOP
        {
            //---Menu---
            Console.Write("1. Write\n" +
                              "2. Display\n" +
                              "3. Load\n" +
                              "4. Save\n" +
                              "5. Quit\n" +
                              "   > ");
            //----------

            userInput = Console.ReadLine();

            if (userInput == "1")           // WRITE complete
            {
                string newPrompt = generator.GetRandomPrompt();             // get random prompt
                DateTime currentTime = DateTime.Now;                        // get time
                string dateText = currentTime.ToShortDateString();          // convert to string

                Console.WriteLine(newPrompt);                               // display

                userInput = Console.ReadLine();                             // get user input


                Entry entry = new Entry(dateText, newPrompt, userInput);    // make new entry obj
                journal.AddEntry(entry);                                    // add entry to journal
            }
            else if (userInput == "2")      // DISPLAY
            {
                journal.DislayAll();
            }
            else if (userInput == "3")      // LOAD
            {
                Console.Write("Please enter the filename:\n   > ");
                filename = Console.ReadLine();                             // get filename

                Console.Write("Would you like to overwrite your unsaved entries? (Y/N)\n   > ");
                userInput = Console.ReadLine();

                if (userInput == "Y" || userInput == "y")                   // clear list to load file3
                {
                    journal._entries.Clear();
                    journal.LoadFromFile(filename);                    // Load from filename into journal


                }
                else if (userInput == "N" || userInput == "n")              // don't clear list
                {
                    journal.LoadFromFile(filename);                    // Load from filename into journal
                }
                else
                {
                    Console.WriteLine("-- Error: Invalid Input --");
                }
                // will do return to menu if an invalid answer is given. just easier loll
            }
            else if (userInput == "4")      // SAVE
            {
                Console.Write("Please enter the filename:\n   > ");
                filename = Console.ReadLine();

                Console.Write("WARNING: This will overwrite your current file. Would you like to continue? (Y/N)\n   > ");
                userInput = Console.ReadLine();

                if (userInput == "Y" || userInput == "y")
                {
                    journal.SaveToFile(filename);
                }
                else
                {
                    Console.WriteLine("Please Load your save file before continuing.\n");
                }
            }
            else if (userInput == "5")      // Quit
            {
                Console.Write("Are you sure you would like to quit? (Y/N)\n   > ");
                userInput = Console.ReadLine();

                if (userInput == "Y" || userInput == "y")
                {
                    Console.WriteLine("Thank you! \n(press any key to exit)");
                    Console.ReadLine();
                    doLoop = false;
                }
                Console.WriteLine();
            }
        }
    }
}

// "Nov,22,2003","prompt text","emtry text ""says stuff"" and things."
// "Oct,13,2025","prompt text","this is another entry"
// "Jan,15,2026","prompt","oh wow another entry ""cool"""