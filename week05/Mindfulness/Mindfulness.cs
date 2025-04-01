using System;

public class Mindfulness{
    private int _duration;
    private string _typeOfCountDown;

    public Mindfulness(int duration, string typeOfCountDown)
    {
        _duration = duration;
        _typeOfCountDown = typeOfCountDown;
    }
    public void StartCountdown(int seconds, string typeOfCountDown, string activity)
    {
        //Breathe countdown
        if (typeOfCountDown == "count") 
        {
            Console.WriteLine("Countdown starting...");
            for (int i = seconds; i > 0; i--)
            {
                if (i == 1 || i % 10 == 0)
                {
                    System.Console.WriteLine("Breathe in....");
                } else if (i % 5 == 0)
                {
                    System.Console.WriteLine("Breathe out...");
                }

                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
        } 
        //Reflect countdown
        else if (typeOfCountDown == "spinner")
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
        } 
        //List countdown
        else {
            for (int i = seconds; i > 0; i--)
            {
                Thread.Sleep(1000);
            }
        }
        
        DisplayEndingMessage(activity);
    }

    public string DisplayStartingMessage()
    {
        string message = "This activity will help you";
        return message;
    }

    public void DisplayEndingMessage(string activity)
    {
        System.Console.WriteLine($"I hope this {activity} acivity has helped you.\nHave a nice day.");
        
    }
}