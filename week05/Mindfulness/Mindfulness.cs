using System;

public class Mindfulness{
    private int _duration;
    private string _typeOfCountDown;

    public Mindfulness(int duration, string typeOfCountDown)
    {
        _duration = duration;
        _typeOfCountDown = typeOfCountDown;
    }
    public void StartCountdown(int seconds, string typeOfCountDown)
    {
        if (typeOfCountDown == "count") 
        {
            Console.WriteLine("Countdown starting...");
            for (int i = seconds; i > 0; i--)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
        } else if (typeOfCountDown == "spinner")
        {
            string[] spinner = {"|", "/", "-", "\\"};
            int spinnerIndex = 0;

            Console.WriteLine("Spinner in progress...");
            for (int i = 0; i < seconds ; i++)
            {
                Console.WriteLine(spinner[spinnerIndex] + "\r");
                spinnerIndex = (spinnerIndex + 1) % spinner.Length;
                Thread.Sleep(1000);
            }
        } else {
            for (int i = seconds; i > 0; i--)
            {
                Thread.Sleep(1000);
            }
        }
        
        Console.WriteLine("Countdown complete!");
    }

    public string DisplayStartingMessage()
    {
        Console.WriteLine("This activity will help you ");
    }
}