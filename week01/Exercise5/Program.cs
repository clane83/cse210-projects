using System;

class Program
{
    static void Main(string[] args)
    {


        void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            return Console.ReadLine();
        }
        
        int PromptUserNumber()
        {
            Console.WriteLine("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        int SquareNumber (int number)
        {
            int square = number * number;
            return square;
        }

        static void DisplayResult(string name, int result)
        {
            Console.WriteLine($"{name}, the square of your number is {result}");
        }
        

        DisplayWelcome();
        string userName = PromptUserName();
        int number = PromptUserNumber();
        int result = SquareNumber(number);
        DisplayResult(userName, result);



    }
}