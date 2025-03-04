using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = 100;
        int sum = 0;
        
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (true)
        {
            Console.Write("Enter number:");
            number = int.Parse(Console.ReadLine());
            if (number == 0)
            {
                break;
            }
            else
            {
                numbers.Add(number);
            }
            

        }

        foreach (int num in numbers)
        {
            sum += num;
        }

        int max_number = -999;
        int min_number = 999;
        foreach (int num in numbers)
        {
            if (num > max_number)
            {
                max_number = num;
            }
        }
        foreach (int num in numbers)
        {
            if (num < min_number && num > 0)
            {
                min_number = num;
            }
        }

        int list_count = numbers.Count;
        decimal average = (decimal)sum / list_count;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number: {max_number}");
        Console.WriteLine($"The smallest positive number: {min_number}");

        numbers.Sort();
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
        

    }
}