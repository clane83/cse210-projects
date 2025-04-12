using System;

public class Running : Exercise
{
//Running: distance

    public Running(double distance, int minutes, int distanceType ) : base (distance, minutes, distanceType){

    }

    public override double GetSpeed(){
    // Speed (mph or kph) = (distance / minutes) * 60
    // Speed = 60 / pace
        double distance = GetDistance();
        double minutes = GetMinutes();
        return (distance / minutes) * 60;
    
    }

    public override double GetPace(){
    // Pace (min per mile or min per km)= minutes / distance
    // Pace = 60 / speed
    double pace = 60 / GetSpeed();
    return pace;

    }

    

    public override string GetDetailsString() {
        string formattedDate = GetDate().ToString("dd MMM yyyy");
        //03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
        return $"{formattedDate} Running ({GetMinutes()} min) - Distance {GetDistance()} {GetDistanceType()}, Speed {GetSpeed()} {GetDistanceAbbreviation()}, Pace: {GetPace()} min per {GetDistanceType()}";
    }

}

