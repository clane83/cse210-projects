using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public string _name; //Journal owner's name
    public List<Entries> _journal = new List<Entries>();  //Store entries in a list

    public string Display()
    {
        string result = $"{_name} \nJournal Entries: \n";

        foreach (Entries entry in _journal)
        {
            result += $"{entry.Display()}\n";
        }
        return result;
    }

    //Method to save journal to a file
    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_name); // Save journal owner's name
            foreach (Entries entry in _journal)
            {
                writer.WriteLine($"{entry._entrydate}|{entry._entry}"); // Save entries with a separator
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
            _name = lines[0]; // First line is the journal owner's name

            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split('|'); // Splitting saved data
                Entries entry = new Entries
                {
                    _entrydate = parts[0],
                    _entry = parts[1]
                };
                _journal.Add(entry);
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
    

}