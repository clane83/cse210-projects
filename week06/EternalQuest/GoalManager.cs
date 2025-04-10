using System;
using System.IO;

public class GoalManager {
    private int _score;
    private List<Goal> _goals = new List<Goal>();
    



// Start - This is the "main" function for this class. It is called by Program.cs, and then runs the menu loop.
    public string Start(){
        return "Menu Options: \n  1. Create New Goal\n  2. List Goals\n  3. Save Goals\n  4. Load Goals\n  5. Record Event\n  6. Quit";
         
    }

// Type of Goal - This is the function that the user can choose the goal they want to create
    public string GoalType(){
        return "Choose the type of goal\n  1.Simple Goal\n  2. Checklist Goal\n  3. Eternal Goal";
    }


// DisplayPlayerInfo - Displays the players current score.
// ListGoalNames - Lists the names of each of the goals.
// ListGoalDetails - Lists the details of each goal (including the checkbox of whether it is complete).
// CreateGoal - Asks the user for the information about a new goal. Then, creates the goal and adds it to the list.
    public void AddGoal(Goal goal)
        {
            _goals.Add(goal);
        }
// RecordEvent - Asks the user which goal they have done and then records the event by calling the RecordEvent method on that goal.
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
                string target = parts[4];
                string bonus = parts[5];
                string completed = parts[6]; // figure out error at this point
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
