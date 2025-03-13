using System;
using System.ComponentModel.DataAnnotations;


public class Entries
{
    public string _entry {get; set;} //Individual journal entry
    public string _entrydate {get; set;}  //Date of entry

    public string Display()
    {
        return $"{_entrydate} - {_entry}";
    }
}