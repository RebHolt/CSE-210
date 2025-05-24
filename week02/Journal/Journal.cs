using System.IO.Compression;
using System.Runtime.CompilerServices;

public class Journal
{
    // initialize member var
    public List<Entry> _entries = new List<Entry>();

    //constructor   dont need, as we're adding variables to a list
    // public Journal(List<Entry> entries)
    // {
    //     _entries = entries;
    // }

    // -- Methods --
    public void AddEntry(Entry item)
    {
        _entries.Add(item);
    }

    public void DislayAll()
    {
        foreach (Entry item in _entries)
        {
            item.Display();
            Console.WriteLine();
        }
    }

    public void SaveToFile(string filename)
    {
        System.IO.File.WriteAllText(filename, string.Empty);        // clear file

        foreach (Entry entry in _entries)
        {
            Console.WriteLine("-- WRITING TO FILE... --");      //DEBUG
            using (StreamWriter outputfile = File.AppendText(filename))
            {
                outputfile.WriteLine(entry._date);
                outputfile.WriteLine(entry._promptText);
                outputfile.WriteLine(entry._entryText);

            }
        }


    }

    public void LoadFromFile(string file)
    {

    }

}