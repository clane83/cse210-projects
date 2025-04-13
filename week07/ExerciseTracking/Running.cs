using System;

public class Running : Exercise
{
//Running: distance

    public Running(double distance, int minutes, int distanceType ) : base (distance, minutes, distanceType){

    }

    
    public override string GetDetailsString() {
        string formattedDate = GetDate().ToString("dd MMM yyyy");
        //03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
        return $"{formattedDate} Running ({GetMinutes()} min) - Distance {GetDistance()} {GetDistanceType()}, Speed {GetSpeed():0.00} {GetDistanceAbbreviation()}, Pace: {GetPace():0.00} min per {GetDistanceType()}";
    }

}

