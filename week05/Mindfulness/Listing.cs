using System;

public class Listing : Mindfulness
{
    private int _duration = 0;
    private string _typeOfCountDown;
    private List<string> _listingPrompt;

    public Listing(int seconds, string typeOfCountDown) : base(seconds, typeOfCountDown)
    {
        _duration = seconds;
        _typeOfCountDown = typeOfCountDown;
        _listingPrompt = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }
    public void StartListingActivity()
    {
        DisplayListingMessage();
        System.Console.WriteLine($"Prompt: {RandomPrompt()}");
        StartCountdown(_duration, _typeOfCountDown, "listing");
    }
    public void DisplayListingMessage()
    {
        
        Console.WriteLine($"{DisplayStartingMessage()} reflect on the good things in your life by having you list as many things as you can in a certain area.");
    }

    public string RandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_listingPrompt.Count);
        return _listingPrompt[index];
    }

    public void DisplayListCount(int itemCount)
    {
        Console.WriteLine($"Time's up! You listed {itemCount} items.");
    }

}