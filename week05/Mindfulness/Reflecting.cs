using System;

public class Reflecting : Mindfulness
{
    private int _duration = 0;
    private string _typeOfCountDown;

    public Reflecting(int seconds, string typeOfCountDown) : base(seconds, typeOfCountDown)
    {
        _duration = seconds;
        _typeOfCountDown = typeOfCountDown;
    }
    public void StartReflectingActivity()
    {
        StartCountdown(_duration, _typeOfCountDown);
    }
}