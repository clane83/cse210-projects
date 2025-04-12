using System;

public abstract class Exercise{

    private double _distance;
    private int _minutes;
    private string _distanceType;
    private DateTime _date = DateTime.Now;


    
    public Exercise(double distance, int minutes, int distanceType){
        _distance = distance;
        _minutes = minutes;

        if (distanceType == 1)
        {
            _distanceType = "km";
        } else{
            _distanceType = "miles";
        }
        
    }

    public void SetDistance(int distance){
        _distance = distance;
    }

    public double GetDistance(){
        return _distance;
    }

    public DateTime GetDate(){
        return _date;
    }
    public int GetMinutes(){
        return _minutes;
    }

    public string GetDistanceType(){
        return _distanceType;
    }

    public string GetDistanceAbbreviation()
{
        if (_distanceType == "miles")
        {
            return "mph";
        }
        else
        {
            return "kph";
        }
    }

    public abstract double GetSpeed();
    // Speed (mph or kph) = (distance / minutes) * 60
    // Speed = 60 / pace

    public abstract double GetPace();
    // Pace (min per mile or min per km)= minutes / distance
    // Pace = 60 / speed

    public abstract string GetDetailsString();
//03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
        


}








// In addition, your program must:

// Use inheritance to avoid duplicating shared attributes and methods.
// Use method overriding for the calculation methods.
// Follow the principles of encapsulation, making sure each member variable is private.