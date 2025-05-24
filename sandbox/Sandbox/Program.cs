using System;
using System.Drawing;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.IO;
using System.Text;
using System.Runtime.ExceptionServices;
using Microsoft.VisualBasic;
using System.IO.Enumeration;

class Program
{
    static void Main(string[] args)
    {
        string yeet = Path.GetFullPath("myFile.txt");

        Console.WriteLine(yeet);
        string filename = @"myFile.txt";
        using (StreamWriter outputfile = new StreamWriter(filename))
        {
            //add text to file
            outputfile.WriteLine("Fiasdf");

            // use $ to include variables like console.writeline
            string color = "Blue";
            outputfile.WriteLine($"Fav color: {color}");
        }

    }
}

