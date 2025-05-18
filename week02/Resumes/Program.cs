using System;

class Program
{
    static void Main(string[] args)
    {
        // thanks to the constructor, dont have to use tedious dot notation.
        // all on one line :)
        Job job1 = new Job("Microsoft", "Software Engineer", 2003, 2025);
        Job job2 = new Job("The Store", "Cashier", 2025, 2460);
        Resume resume = new Resume("Becky Holt");

        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.Display();
    }
}