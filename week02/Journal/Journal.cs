using System;
using System.Collections.Generic;

public class Journal
{
    public string _name;
    public List<Entries> _journal = new List<Entries>();

    public string Display()
    {
        string result = $"{_name} \nJournal Entries: \n";

        foreach (Entries entry in _journal)
        {
            result += $"{entry.Display()}\n";
        }
        return result;
    }
}