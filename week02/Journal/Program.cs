using System;

class Program
{
    static void Main(string[] args)
    {

        string quit = "no";

        while (quit == "no")
        {
            Console.WriteLine("Please select one of the following choices (number):");
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            int choice = int.Parse(Console.ReadLine());

            //Create Entries into Journal
            Entries entry1 = new Entries();

            //Create journal and add entries to journal
            Journal journal1 = new Journal();

            // File name for saving and loading
            string filename = "journal.txt";

            //choice 1 to write entries to list
            if (choice == 1)
            {
                //Create and instance of the PromptGenerator
                PromptGenerator promptGenerator = new PromptGenerator();

                string randomPrompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"Prompt: {randomPrompt}");
                string journalEntry = Console.ReadLine();

                //create entries
                entry1._entrydate = DateTime.Now.ToShortDateString();
                entry1._prompt = randomPrompt;
                entry1._entry = journalEntry;

                //add entries to list
                journal1._journal.Add(entry1);
            }
            // choice 2 to display entries in journal
            else if (choice == 2)
            {
                journal1.Display();
            }
            //choice 3 to load journal from file
            else if (choice == 3)
            {
                journal1.LoadFromFile(filename);
                Journal loadedJournal = new Journal();
                loadedJournal.LoadFromFile(filename);
                //Console.WriteLine("\nJournal loaded from file:");
                Console.WriteLine(loadedJournal.Display());
            }
            //choice 4 to save the journal
            else if (choice == 4)
            {   
                // Save to file
                journal1.SaveToFile(filename);
                Console.WriteLine("Journal saved to file.");
            }
            else if (choice == 5)
            {
                journal1.SaveToFile(filename);
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