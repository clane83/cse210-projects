using System;

class Program
{
    static void Main(string[] args)
    {
        int exercise = 0;
      
        double distance = 0.0;
        int distanceType = 0;
        int minutes = 0;
       
        

        ExerciseManager exerciseManager = new ExerciseManager();
        Console.WriteLine(exerciseManager.AskUserForExercise());
        exercise = int.Parse(Console.ReadLine());


        Console.WriteLine(exerciseManager.AskUserDistance());
        distance = double.Parse(Console.ReadLine());

        Console.WriteLine(exerciseManager.AskUserMeasurement());
        distanceType = int.Parse(Console.ReadLine());
        
        Console.WriteLine(exerciseManager.AskUserTime());
        minutes = int.Parse(Console.ReadLine());

        if (exercise == 1)
        {
            Running running = new Running(distance, minutes, distanceType);
            Console.WriteLine(running.GetDetailsString());
        } else {
            Console.WriteLine("Still working on");
        }

    }


}