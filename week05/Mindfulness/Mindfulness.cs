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
            // Console.WriteLine("Countdown starting...");
            Breathing breathingInstance = new Breathing(seconds, typeOfCountDown);
            for (int i = seconds; i > 0; i--)
            {
                if (i == 1 || i % 10 == 0)
                {
                    breathingInstance.DisplayBreatheIn();
                } else if (i % 5 == 0)
                {
                    breathingInstance.DisplayBreatheOut();
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

            int questionIndex = 0;
            int questionPause = seconds / 9;
            if (questionPause < 5)
            {
                questionPause = 5;
            }
            System.Console.WriteLine(questionPause);
            Reflecting reflectingInstance = new Reflecting(seconds, typeOfCountDown);
            // Console.WriteLine("Spinner in progress...");
            for (int i = seconds; i > 0; i--)
            {   
                if (i % questionPause == 0)
                {
                    reflectingInstance.DisplayQuestions(questionIndex);
                    questionIndex += 1;
                    if (questionIndex == 8)
                    {
                        break;
                    }
                }

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