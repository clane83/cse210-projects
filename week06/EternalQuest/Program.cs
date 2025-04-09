using System;

class Program
{
    static void Main(string[] args)
    {

        string goalName = "";
        string goalDescription = "";
        string goalPoints = "";
        bool goalComplete = false;
    
        bool continueProgram = true;
        while (continueProgram)
        {
            GoalManager startMenu = new GoalManager();

            // Call the Start() method and print its output
            Console.WriteLine(startMenu.Start());
            Console.WriteLine("Select a choice from the menu: ");
            int answer = int.Parse(Console.ReadLine());

            if (answer == 6)
            {
                Console.WriteLine("Goodbye!");
                continueProgram = false;
            } else if  (answer == 1)
            {
                //create simple goal
                Console.WriteLine("What is your simple goal? ");
                goalName = Console.ReadLine();
                Console.WriteLine("What is a short description of it?");
                goalDescription = Console.ReadLine();
                Console.WriteLine("How many points is it worth?");
                goalPoints = Console.ReadLine();
                SimpleGoal simpleGoal = new SimpleGoal(goalName, goalDescription, goalPoints, goalComplete);
                Console.WriteLine(simpleGoal.GetDetailsString());
            } 
        }

        




        //create simple goal
        // SimpleGoal simpleGoal1 = new SimpleGoal("run a marathon", "ran 26.2 miles", "1000", true);
        // System.Console.WriteLine(simpleGoal1.GetDetailsString());

        //create eternal goal
        EternalGoal eternal1 = new EternalGoal("Read scriptures", "Read the Book of Mormon for 10 minutes", "50");
        Console.WriteLine(eternal1.GetDetailsString());

        //create checklist goal
        ChecklistGoal checklist1 = new ChecklistGoal("Teach in Primary", "Teach in primary 3 times this month", "0", "3", "100", "50");
        Console.WriteLine(checklist1.GetDetailsString());
    }
}