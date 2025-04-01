using System;

public class Breathing : Mindfulness
{
    private int _duration = 0;
    private string _typeOfCountDown;

    public Breathing(int seconds, string typeOfCountDown) : base(seconds, typeOfCountDown)
    {
        _duration = seconds;
        _typeOfCountDown = typeOfCountDown;
    }
    public void StartBreathingActivity(int activity)
    {
        DisplayBreatheMessage();
        StartCountdown(_duration, _typeOfCountDown, "breathing");
        
    }

    public void DisplayBreatheMessage()
    {
        
        Console.WriteLine($"{DisplayStartingMessage()} relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
    }

    public void DisplayBreatheIn()
    {
       Console.WriteLine("Breathe in....");
    }

    public void DisplayBreatheOut()
    {
       Console.WriteLine("Breathe out....");
    }

}