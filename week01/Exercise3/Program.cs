using System;

class Program
{
    static void Main(string[] args)
    {
       
        string result = "";
        string keep_playing = "yes";

        while (keep_playing == "yes")
        {
            int guesses = 0;
            Console.WriteLine("What is the magic number?");
            int magic_number = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("What is your guess?");
                int guess = int.Parse(Console.ReadLine());
                

                if (magic_number == guess)
                {
                    result = "You guessed it!";
                }
                else if (magic_number < guess)
                {
                    result = "Lower";
                }
                else
                { 
                    result = "Higher";
                }
                guesses++;
                Console.WriteLine(result);
            } while (result != "You guessed it!");

            Console.WriteLine($"It took you {guesses} guesses");
            Console.WriteLine("Do you want to keep playing");
            keep_playing = Console.ReadLine();
        }
        Console.WriteLine("Game is over");
    }
}