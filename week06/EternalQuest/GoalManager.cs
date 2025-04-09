using System;

public class GoalManager {
    private int _score;
    private List<Goal> _goals = new List<Goal>();

    public string Start(){
        return "Menu Options: \n  1. Create New Goal\n  2. List Goals\n  3. Save Goals\n  4. Load Goals\n  5. Record Event\n  6. Quit";
        
        
    }

// Start - This is the "main" function for this class. It is called by Program.cs, and then runs the menu loop.
// DisplayPlayerInfo - Displays the players current score.
// ListGoalNames - Lists the names of each of the goals.
// ListGoalDetails - Lists the details of each goal (including the checkbox of whether it is complete).
// CreateGoal - Asks the user for the information about a new goal. Then, creates the goal and adds it to the list.
// RecordEvent - Asks the user which goal they have done and then records the event by calling the RecordEvent method on that goal.
// SaveGoals - Saves the list of goals to a file.
// LoadGoals - Loads the list of goals from a file.

    // public int SetScore(int score) {
    //     _score = score;
    // }

    // public void AddGoal(string shortName, string description, string points)
    // {
    //     _goals.Add(new Goal(shortName, description, points));
    // }

}
