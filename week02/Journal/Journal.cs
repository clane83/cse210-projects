using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entries> _journal = new List<Entries>();  //Store entries in a list

    public void Display()
{
    if (_journal.Count == 0)
    {
        Console.WriteLine("Journal is empty.");
    }
    else
    {
        foreach (Entries entry in _journal)
        {
            Console.WriteLine(entry.Display());
            Console.WriteLine("----------------------------");
        }
    }
}

    //Method to save journal to a file
    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entries entry in _journal)
            {
                writer.WriteLine($"{entry._entrydate}|{entry._prompt}|{entry._entry}"); // Save entries with a separator
            }
        }
    }

    // Method to load journal entries from a file
    public void LoadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            _journal.Clear(); // Clear existing entries before loading
            string[] lines = File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                string[] parts = line.Split('|'); // Splitting saved data
                if (parts.Length == 3)
                {
                    Entries entry = new Entries
                    {
                        _entrydate = parts[0],
                        _prompt = parts[1],
                        _entry = parts[2]
                    };
                    _journal.Add(entry);
                }
                
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
    

}