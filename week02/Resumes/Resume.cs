public class Resume
{
    string _name;
    public List<Job> _jobs = new List<Job>();


    public Resume(string name)
    {
        _name = name;
    }

    public void Display()
    {
        Console.WriteLine($"Name: {_name}\nJobs:");
        foreach (Job b in _jobs)
        {
            b.Display();
        }
    }
}