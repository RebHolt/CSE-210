public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public string test;

    public Entry(string date, string promptText, string entryText)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
    }

    public void Display()
    {
        Console.WriteLine($"\n{_date}" +
                          $"\n{_promptText}" +
                          $"\n\t{_entryText}");
    }
}