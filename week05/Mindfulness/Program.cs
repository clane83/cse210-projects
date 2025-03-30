using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Menu Options:");
        Console.WriteLine("\t1. Start breating activity\n\t2. Start reflecting activity\n\t3. Start listing activity\n\t4. Quit\nSelect a choice from the menu:");
        int option = int.Parse(Console.ReadLine());
        Console.WriteLine("How long in seconds? ");
        int duration = int.Parse(Console.ReadLine());

        // Mindfulness mindfulness1 = new Mindfulness();
        // mindfulness1.StartCountdown(duration, countDownType);

        if (option == 1)
        {
            Breathing breath1 = new Breathing(duration, "count");
            breath1.StartBreathingActivity();
        } else if (option == 2)
        {
            Reflecting reflect1 = new Reflecting(duration, "spinner");
            reflect1.StartReflectingActivity();
        } else if (option == 3)
        {
            Listing list1 = new Listing(duration, "");
            list1.StartListingActivity();
        } else if (option == 4)
        {
            Console.WriteLine("You have chosen Quit!\nHave a nice day!")
        }else
        {
            Console.WriteLine("Please make a valid option");
        }
        
        
    
    }
}