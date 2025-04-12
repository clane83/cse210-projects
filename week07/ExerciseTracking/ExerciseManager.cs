using System;

public class ExerciseManager{


//prompt user for exercise
    public string AskUserForExercise(){
        return "What exercise did you completed today?\n  1. Running\n  2. Cycling\n  3. Swimming\nEnter the number:";
    }

//prompt user for distance
    public string AskUserDistance(){
        return "How far did you go?";
    }

//prompt user for measurment metric or imperial
    public string AskUserMeasurement(){
        return "Choose measurement type:\n  1. Metric - meters\n  2. Imperial - miles\nEnter the number:";
    }

}