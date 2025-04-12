using System;

class Program
{
    static void Main(string[] args)
    {
        int exercise = 0;
      
        double distance = 0.0;
        int distanceType = 0;
       
        

        ExerciseManager exerciseManager = new ExerciseManager();
        Console.WriteLine(exerciseManager.AskUserForExercise());
        exercise = int.Parse(Console.ReadLine());


        Console.WriteLine(exerciseManager.AskUserDistance());
        distance = int.Parse(Console.ReadLine());

        Console.WriteLine(exerciseManager.AskUserMeasurement());
        distanceType = int.Parse(Console.ReadLine());
        


    }


}