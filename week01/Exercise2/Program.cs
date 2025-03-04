using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?(ex. 90) ");
        int grade = int.Parse(Console.ReadLine());
        
        if (grade >= 90)
        {
            Console.WriteLine("A");
        }
        else if (grade >= 80)
        {
            Console.WriteLine("B");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("C");
        }
        else if (grade >= 60)
        {
            Console.WriteLine("D");
        }
        else
        {
            Console.WriteLine("F");
        }


    }
}