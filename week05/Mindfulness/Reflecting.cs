using System;

public class Reflecting : Mindfulness
{
    private int _duration = 0;
    private string _typeOfCountDown;
    private List<string> _prompts;
    private List<string> _reflectQuestion;

    public Reflecting(int seconds, string typeOfCountDown) : base(seconds, typeOfCountDown)
    {
        _duration = seconds;
        _typeOfCountDown = typeOfCountDown;
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };
        _reflectQuestion = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }
    public void StartReflectingActivity()
    {
        DisplayReflectingMessage();
        System.Console.WriteLine($"Prompt: {RandomPrompt()}");
        StartCountdown(_duration, _typeOfCountDown, "reflecting");
    }
    public void DisplayReflectingMessage()
    {
        
        Console.WriteLine($"{DisplayStartingMessage()} reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
    }
    public string RandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public void DisplayQuestions(int index)
    {
       Console.WriteLine(_reflectQuestion[index]);
    }

}