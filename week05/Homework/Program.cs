using System;

class Program
{
    static void Main(string[] args)
    {
        
        MathAssignment mathassignment1 = new MathAssignment("Joe", "Fraction", "7.3", "8-19");
        
        Console.WriteLine(mathassignment1.GetSummary());
        Console.WriteLine(mathassignment1.GetHomeWorkList());
        System.Console.WriteLine("");

        WritingAssignment writingassignment1 = new WritingAssignment("Bailey", "History", "President's on Parade");

        Console.WriteLine(writingassignment1.GetSummary());
        Console.WriteLine(writingassignment1.GetWritingInformation());
    }
}