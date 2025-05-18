using System;
using System.Drawing;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {

        // Person person1 = new Person();

        // person1._givenName = "Emma";
        // person1._familyName = "Smith";
        // person1.ShowWesternName();

        // Person person2 = new Person();
        // person2._givenName = "Joseph";
        // person2._familyName = "Smith";
        // person2.ShowWesternName();


        // in main function

        House bobHome = new House();
        bobHome._owner = "Bob Family";

        bobHome._blinds.Add(kitchen);

        double amount = bobHome._blinds[0].GetArea();

        foreach (Blind b in bobHome._blinds)
        {
            double amount = b.GetArea();
        }


    }
}
