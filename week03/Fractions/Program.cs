using System;
using System.Dynamic;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(6);
        Fraction f3 = new Fraction(5, 9);

        Console.WriteLine(f3.GetDecimalValue());



    }
}