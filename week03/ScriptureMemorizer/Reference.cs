using System;
using System.Collections.Generic;


public class Reference
{
    private string _book = "none";
    private int _chapter = 0;
    private string _verse   = "none";
    private string _endVerse = "none";



    public Reference(List<string> verse)
    {
        if (verse.Count < 4)
        {
            _book = verse[0];
            _chapter = int.Parse(verse[1]);
            _verse = verse[2];
        }
        else 
        {
            _book = verse[0];
            _chapter = int.Parse(verse[1]);
            _verse = verse[2];
            _endVerse = verse[3];
            
        }
    }
    // public Reference(string book, string chapter, string verse)
    // {
    //     _book = book;
    //     _chapter = chapter;
    //     _verse = verse;
    //     _endVerse = "";
    // }

    // public Reference(string book, string chapter, string verse, string endVerse)
    // {
    //     _book = book;
    //     _chapter = chapter;
    //     _verse = verse;
    //     _endVerse = endVerse;
    // }

    public string GetDisplayText()
    {
        string text = "";
       
        if (_endVerse != "none")
        {
            text = $"{_book} {_chapter}:{_verse}-{_endVerse}";
        } else{
            text = $"{_book} {_chapter}:{_verse}";
        }
        return text;
    }
}