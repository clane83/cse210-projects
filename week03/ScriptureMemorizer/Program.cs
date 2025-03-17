using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your favorite scripture? (e.g., John 3:16)");
        string favoriteVerse = Console.ReadLine();
        string[] verseParts = favoriteVerse.Split(":");
        if (verseParts.Length < 2)
        {
            Console.WriteLine("Incorrect entry.  Please enter in 'Book Chapter:Verse' format.");
            return;
        }

        string bookChapter = verseParts[0];
        string verse = verseParts[1];

        string[] bookChapterParts = verseParts[0].Split(" ");
        if (bookChapterParts.Length < 2)
        {
            Console.WriteLine("Incorrect entry.  Please enter in 'Book Chapter:Verse' format.");
            return;
        }

        string book = bookChapterParts[0];
        string chapter = bookChapterParts[1];

        Console.WriteLine("What is does the verse say? ");
        string text = Console.ReadLine();



        Reference reference = new Reference(book, chapter, verse);
        Console.WriteLine(reference.GetDisplayText()); // Display the formatted reference
        
        // bool result; 
  
        // // checking if G is a 
        // // Unicode letter or not 
        // char ch1 = 'G'; 
        // result = Char.IsLetter(ch1); 
        // Console.WriteLine(result); 
  
        // // checking if '6' is a 
        // // Unicode letter or not 
        // char ch2 = '6'; 
        // result = Char.IsLetter(ch2); 
        // Console.WriteLine(result);

        // char ch3 = ','; 
        // result = Char.IsLetter(ch3); 
        // Console.WriteLine(result);

        // Console.Clear();
       
    }
}