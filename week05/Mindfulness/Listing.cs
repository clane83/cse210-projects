using System;

public class Listing : Mindfulness
{
    private int _duration = 0;
    private string _typeOfCountDown;

    public Listing(int seconds, string typeOfCountDown) : base(seconds, typeOfCountDown)
    {
        _duration = seconds;
        _typeOfCountDown = typeOfCountDown;
    }
    public void StartListingActivity()
    {
        StartCountdown(_duration, _typeOfCountDown, "listing");
    }

}