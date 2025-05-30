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
        using (StreamWriter outputfile = new StreamWriter(filename))         // create new StreamWriter obj, can write to it like console.
        {
            foreach (Entry item in _entries)                                 // for each entry
            {
                //format entryText
                string entryPrepped = item._entryText.Replace("\"", "\"\"");        //replace quotes with double quotes

                outputfile.WriteLine($"\"{item._date}\",\"{item._promptText}\",\"{entryPrepped}\"");
            }


        }
    }

    public void LoadFromFile(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string i in lines)
        {
            string cleanLine = i.Replace("\"\"", "*");          // replace double quotes with asterisk
            string[] parts = cleanLine.Split(",\"");            // split ,"

            int count = 0;
            foreach (string j in parts)
            {
                cleanLine = j;
                cleanLine = cleanLine.Replace("\"", "");
                cleanLine = cleanLine.Replace("*", "\"");



                parts[count] = cleanLine;                       // replace parts with cleanLine
                count++;
            }
            Entry entry = new Entry(parts[0], parts[1], parts[2]);      // make new entry obj
            AddEntry(entry);                                            // Add to journal
        }


    }
}