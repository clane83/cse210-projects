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
    public void StartBreathingActivity()
    {
        StartCountdown(_duration, _typeOfCountDown);
    }

}