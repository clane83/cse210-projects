using System;
using System.ComponentModel.DataAnnotations;


public class Entries
{
    public string _entry {get; set;} //Individual journal entry
    public string _entrydate {get; set;}  //Date of entry
    public string _prompt;
    public string Display()
    {
        return $"Date: {_entrydate} - Prompt: {_prompt}\n{_entry}";
    }
}