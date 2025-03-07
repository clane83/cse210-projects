using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        Resumes resume1 = new Resumes();
        job1._jobTitle = "Software Engineering";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;
        
        
        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        resume1._name = "Tina Lane";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        Console.WriteLine(resume1.Display());
        // Console.WriteLine(job1.Display());
        // Console.WriteLine(job2.Display());
       

    }
}