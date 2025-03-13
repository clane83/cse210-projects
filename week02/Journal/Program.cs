using System;

class Program
{
    static void Main(string[] args)
    {

        Entries entry1 = new Entries();
        entry1._entrydate = "03/10/2025";
        entry1._entry = "Today I helped my daughter with her homework.  It did not go very well.  She complained the entire time.";
        
        Entries entry2 = new Entries();
        entry2._entrydate = "03/11/2025";
        entry2._entry = "I was able to get all my homework done and turned in.  I am finally ahead of schedule.";

        Journal journal1 = new Journal
        {
            _name = "Tina's Journal"
        };
        
        journal1._journal.Add(entry1);
        journal1._journal.Add(entry2);


        Console.WriteLine(journal1.Display());
    }
}