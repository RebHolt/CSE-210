using System;
using System.ComponentModel;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

class Program
{
    static void Main(string[] args)
    {
        Entry entry = new Entry("Date", "Prompt", "Entryoaopfkeoakfopkaspofekapok");
        Journal journal = new Journal();
        PromptGenerator generator = new PromptGenerator();

        journal.AddEntry(entry);
        entry = new Entry("thing", "2", "3");
        journal.AddEntry(entry);

        string dir = @"D:\C_programs\Notes\CSE-210\week02\Journal";
        string thing = @"..\..\..";

        Directory.SetCurrentDirectory(thing);
        Console.Write(Directory.GetCurrentDirectory());

        journal.SaveToFile("save.txt");
    }
}