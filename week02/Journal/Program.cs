using System;

class Program
{
    static void Main(string[] args)
    {
        
        //Create journal and add entries to journal
        Journal journal = new Journal();

        // File name for saving and loading
        string filename = "journal.txt";

        string quit = "no";

        while (quit == "no")
        {
            Console.WriteLine("Please select one of the following choices (number):");
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            
            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Please enter a number");
            }


            //choice 1 to write entries to list
            if (choice == 1)
            {
                //Create and instance of the PromptGenerator
                PromptGenerator promptGenerator = new PromptGenerator();

                string randomPrompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"Prompt: {randomPrompt}");
                string journalEntry = Console.ReadLine();

                //Create Entries into Journal
                Entries entry = new Entries();
            
                //create entries
                entry._entrydate = DateTime.Now.ToShortDateString();
                entry._prompt = randomPrompt;
                entry._entry = journalEntry;

                //add entries to list
                journal._journal.Add(entry);
            }
            // choice 2 to display entries in journal
            else if (choice == 2)
            {
                journal.Display();
            }
            //choice 3 to load journal from file
            else if (choice == 3)
            {
                journal.LoadFromFile(filename);
                journal.Display();

            }
            //choice 4 to save the journal
            else if (choice == 4)
            {   
                // Save to file
                journal.SaveToFile(filename);
                Console.WriteLine("Journal saved to file.");
            }
            else if (choice == 5)
            {
                journal.SaveToFile(filename);
                Console.WriteLine("Journal saved to file.");
                quit = "yes";
            }
            else
            {
                Console.WriteLine("Please choose an option from the list");
            }
        }
        Console.WriteLine("Have a nice day\n Journal is closed");
    }
}