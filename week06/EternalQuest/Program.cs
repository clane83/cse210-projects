using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();

        string goalName = "";
        string goalDescription = "";
        string goalPoints = "";
        string goalTarget = "";
        string goalBonus = "";
        bool goalComplete = false;
        int answer = 0;
        int goalAnswer = 0;
        string filePath = "";
    
        bool continueProgram = true;
        while (continueProgram)
        {
            

            // Call the Start() method and print its output
            Console.WriteLine(goalManager.Start());
            Console.WriteLine("Select a choice from the menu: ");
            answer = int.Parse(Console.ReadLine());

            if (answer == 6)
            {
                Console.WriteLine("Goodbye!");
                continueProgram = false;
            } else if  (answer == 1)
            {

                Console.WriteLine(goalManager.GoalType());
                goalAnswer = int.Parse(Console.ReadLine());
                
                //get goal info for simple and eternal goals
                Console.WriteLine("What is your goal? ");
                goalName = Console.ReadLine();
                Console.WriteLine("What is a short description of it?");
                goalDescription = Console.ReadLine();
                Console.WriteLine("How many points is it worth?");
                goalPoints = Console.ReadLine();
                if (goalAnswer == 2){
                    Console.WriteLine("How many times to you want to complete this goal?");
                    goalTarget = Console.ReadLine();
                    Console.WriteLine("What are the bonus points for completing the goal?");
                    goalBonus = Console.ReadLine();

            //create checklist goal
                    ChecklistGoal checklistgoal = new ChecklistGoal(goalName, goalDescription, "0", goalTarget, goalBonus, goalPoints);
                    goalManager.AddGoal(checklistgoal);
                } else if (goalAnswer == 1){
            //create simple goal
                    SimpleGoal simplegoal = new SimpleGoal(goalName, goalDescription, goalPoints, goalComplete);
                    goalManager.AddGoal(simplegoal);
                } else if(goalAnswer == 3){
            //create eternal goal
                    EternalGoal eternalgoal = new EternalGoal(goalName, goalDescription, goalPoints);
                    goalManager.AddGoal(eternalgoal);
                } else {
                    Console.WriteLine("Please enter a valid goal type");
                }
                

                // SimpleGoal simpleGoal = new SimpleGoal(goalName, goalDescription, goalPoints, goalComplete);
                // Console.WriteLine(simpleGoal.GetDetailsString());
            } else if  (answer == 2)
            {
                Console.WriteLine(goalManager.GetGoals());
            } else if  (answer == 3)
            {
                Console.WriteLine("Enter the file path to save the goals:");
                filePath = Console.ReadLine();
                goalManager.SaveGoals(filePath);
            } else if (answer == 4)
            {
                Console.WriteLine("Enter the file path to load the goals from:");
                filePath = Console.ReadLine();
                goalManager.LoadGoals(filePath);
            } else if (answer == 5){
                Console.WriteLine(goalManager.GetGoals());
                Console.WriteLine("Which goal would you like to mark completed? ");
                int goalNumber = int.Parse(Console.ReadLine());
                goalManager.RecordEvent(goalNumber);
            } else {
                Console.WriteLine("Please pick a valid option. 1 - 6");
            }

        }

        





    }
}