using System;
using System.IO;

public class GoalManager {
    private int _score = 0;
    private List<Goal> _goals = new List<Goal>();
    



// Start - This is the "main" function for this class. It is called by Program.cs, and then runs the menu loop.
    public string Start(){
        return "Menu Options: \n  1. Create New Goal\n  2. List Goals\n  3. Save Goals\n  4. Load Goals\n  5. Record Event\n  6. Show Score\n  7. Quit";
         
    }

// Type of Goal - This is the function that the user can choose the goal they want to create
    public string GoalType(){
        return "Choose the type of goal\n  1.Simple Goal\n  2. Checklist Goal\n  3. Eternal Goal";
    }


// DisplayPlayerInfo - Displays the players current score.
    public string GetScore(){
        return $"\nYour score: {_score}\n";
    }

// CreateGoal - Asks the user for the information about a new goal. Then, creates the goal and adds it to the list.
    public void AddGoal(Goal goal)
        {
            _goals.Add(goal);
        }
// RecordEvent - Asks the user which goal they have done and then records the event by calling the RecordEvent method on that goal.
    public void RecordEvent(int goalNumber)
{
    int goalIndex = goalNumber - 1;

    if (goalIndex >= 0 && goalIndex < _goals.Count)
    {
        Goal goal = _goals[goalIndex];

    // Check if it's a SimpleGoal
        if (goal is SimpleGoal simpleGoal)
        {
            simpleGoal.SetComplete(true);
            _score += simpleGoal.GetPoints();
            Console.WriteLine($"Marked '{simpleGoal.GetShortName()}' as complete! +{simpleGoal.GetPoints()} points.");
        }
    // Check if it's a Eternal Goal
        else if (goal is EternalGoal eternalGoal)
        {
            _score += eternalGoal.GetPoints();
            Console.WriteLine($"{eternalGoal.GetShortName()} was marked done.  +{eternalGoal.GetPoints()} points.");
        } 
    // Check if it's a ChecklistGoal
        else if (goal is ChecklistGoal checklistGoal)
        {
            _score += checklistGoal.GetPoints();
            checklistGoal.SetAmountCompleted(1);
            Console.WriteLine($"{checklistGoal.GetShortName()} was updated.  +{checklistGoal.GetPoints()} points.");
            if (checklistGoal.GetAmountCompleted() == checklistGoal.GetTarget())
            {
                Console.WriteLine($"You earned a {checklistGoal.GetBonus()} point bonus!!");
                _score += checklistGoal.GetBonus();
            }
            

        }else
        {
            Console.WriteLine("That goal type doesn't get marked complete like a Simple Goal.");
        }
    }
    else
    {
        Console.WriteLine("Invalid goal number.");
    }
    
}


// SaveGoals - Saves the list of goals to a file.

    public void SaveGoals(string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                
                writer.WriteLine(goal.GetStringRepresentation());
                Console.WriteLine(goal);
            }
        }
        // Console.WriteLine("Goals have been saved successfully!");
    }

// LoadGoals - Loads the list of goals from a file.

    public void LoadGoals(string filePath)
    {
        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(filePath);

        _score = int.Parse(lines[0]);

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            string goalType = parts[0];

            if (goalType == "SimpleGoal")
            {
                string name = parts[1];
                string desc = parts[2];
                string points = parts[3];
                bool isComplete = bool.Parse(parts[4]);
                SimpleGoal sg = new SimpleGoal(name, desc, points, isComplete);
                _goals.Add(sg);
            }
            else if (goalType == "ChecklistGoal")
            {
                string name = parts[1];
                string desc = parts[2];
                string points = parts[3];
                string completed = parts[4];
                string target = parts[5];
                string bonus = parts[6]; // figure out error at this point
                ChecklistGoal cg = new ChecklistGoal(name, desc, completed, target, bonus, points);
                _goals.Add(cg);
            }

            else if (goalType == "EternalGoal")
            {
                string name = parts[1];
                string desc = parts[2];
                string points = parts[3];
                EternalGoal eg = new EternalGoal(name, desc, points);
                _goals.Add(eg);
            }
        }

        // Console.WriteLine("Goals loaded successfully.");
    }


//List the goals to the console
    public string GetGoals()
{
    if (_goals.Count == 0)
    {
        return "No goals have been added yet.";
    }

    string result = "Here are your goals:\n";
    for (int i = 0; i < _goals.Count; i++)
    {
        result += $"{i + 1}. {_goals[i].GetDetailsString()}\n";
    }
    return result;
}
    

}
