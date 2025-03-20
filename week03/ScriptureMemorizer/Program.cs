using System;

//User and enter specific verse and verse text. The verse will split and be placed into a new list.
//My daughter will be able to enter a new bible verse each week she has to memorize from her school.
//she will be able to use this each week when she get the new verse.
//the list will be used to populated the reference variables
//hidding words will also hide only words not hidden already
//Randomly chooses how many words to hide between 2 and 4 words

class Program
{
    static void Main(string[] args)
    {   
        string verseText = "";
        Console.Clear();
        Console.WriteLine("Enter the verse you want to memorize (i.e. John 3:16) or press enter to use Proverbs 3:5–6");
        string verse = Console.ReadLine();
        if (verse == "")
        {
            verse = "Proverbs 3:5–6";
            verseText = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";

        } else {
            Console.WriteLine("Enter the verse text");
            verseText = Console.ReadLine();
        }
        //replace the :, - and spaces with commas in the verse string entered by user
        verse = verse.Replace(":", " ");
        verse = verse.Replace("-", " ");
        verse = verse.Replace(" ", ",");

        List<string> verseList = new List<string>();
        //split the string to a list at the commas
        verseList = verse.Split(",").Select(verseList => new string(verseList)).ToList();
        if (verseList.Count < 3 || verseList.Count > 4)
        {
            Console.WriteLine("Please enter a valid verse.");
        }
        Reference reference = new Reference(verseList);
        // Reference reference = new Reference("John", "3", "16");
        // string verseText = "For God so loved the world that he gave his only begotten Son.";
        Scripture scripture = new Scripture(reference, verseText);
        int verstTextCount = verseText.Split(" ").Length;

        //clear the console and display the verse and words
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        string keepHiding = "";
        Console.WriteLine("Type 'quit' to exit or press any key to continue.");
        keepHiding = Console.ReadLine();
        //Keep looping until keepHiding = quit
        while (keepHiding != "quit")
        {
           //IsCompletelyHidden is a method that will check to see if all words are hidden.  
            

            //Randomly choose the amount of words to hide. 2 to 4 words at a time
            Random random = new Random();
            int numberOfWordsToHide = random.Next(2, 4);
            for (int i = 0; i < numberOfWordsToHide; i++)
            {
                scripture.HideRandomWords();
            
            }
                
                
                // scripture.HideRandomWords();
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());
            if (scripture.IsCompletelyHidden() == true)
            {
                Console.WriteLine("You have hidden all the words!");
                keepHiding = "quit";
            } else {
                Console.WriteLine("Type 'quit' to exit or press any key to continue.");
                keepHiding = Console.ReadLine();
            }
            
        }
        
    }
}