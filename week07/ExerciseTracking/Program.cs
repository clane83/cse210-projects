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

        bool chooseExercise = true;
        while (chooseExercise){
            
            Console.WriteLine(exerciseManager.AskUserForExercise());
            exercise = int.Parse(Console.ReadLine());
            
            if (exercise < 3){
                Console.WriteLine(exerciseManager.AskUserMeasurement());
                distanceType = int.Parse(Console.ReadLine());
                Console.WriteLine(exerciseManager.AskUserDistance());
                distance = double.Parse(Console.ReadLine());
                chooseExercise = false;
            } else if (exercise > 3){
                Console.WriteLine("Please choose a valid exercise");
            } else {
                Console.WriteLine(exerciseManager.AskUserMeasurement());
                distanceType = int.Parse(Console.ReadLine());
                Console.WriteLine(exerciseManager.AskUserLaps());
                distance = double.Parse(Console.ReadLine());
                chooseExercise = false;
            }
        }
        


        
        
        Console.WriteLine(exerciseManager.AskUserTime());
        minutes = int.Parse(Console.ReadLine());

        if (exercise == 1)
        {
            Running running = new Running(distance, minutes, distanceType);
            Console.WriteLine(running.GetDetailsString());
        } else if (exercise == 2)
        {
            Cycling cycling = new Cycling(distance, minutes, distanceType);
            System.Console.WriteLine(cycling.GetDetailsString());
        } else if (exercise == 3)
        {
            Swimming swimming = new Swimming(distance, minutes, distanceType);
            System.Console.WriteLine(swimming.GetDetailsString());
        } else {
            Console.WriteLine("Still working on");
        }

    }


}