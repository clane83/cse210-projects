using System;
using System.ComponentModel.DataAnnotations;


public class Entries
{
    public string _entry {get; set;}
    public string _entrydate {get; set;}

    public string Display()
    {
        return $"{_entrydate} - {_entry}";
    }
}