using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?(ex. 90) ");
        int grade = int.Parse(Console.ReadLine());
        int last_digit = grade % 10;
        string letter_grade = "";
        string sign = "";
        string a_or_an = "a";



        if (last_digit >= 7)
        {
            sign = "+";
        }
        else if (last_digit < 3)
        {
            sign = "-";
        }
        



        if (grade >= 90)
        {
            letter_grade = "A";
            if (grade >97) {sign = "";}
        }
        else if (grade >= 80)
        {
            letter_grade = "B";
        }
        else if (grade >= 70)
        {
            letter_grade = "C";
        }
        else if (grade >= 60)
        {
            letter_grade = "D";
        }
        else
        {
            letter_grade = "F";
            sign = "";
        }

        if (letter_grade == "A")
        { a_or_an = "an";}

        Console.WriteLine($"Your grade is {a_or_an} {letter_grade}{sign}");

    }
}