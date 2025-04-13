using System;

public class Cycling : Exercise
{
//Cycling: speed

    public Cycling(double distance, int minutes, int distanceType ) : base (distance, minutes, distanceType){

    }


    public override string GetDetailsString() {
        string formattedDate = GetDate().ToString("dd MMM yyyy");
        //03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
        return $"{formattedDate} Cycling ({GetMinutes()} min) - Distance {GetDistance()} {GetDistanceType()}, Speed {GetSpeed()} {GetDistanceAbbreviation()}, Pace: {GetPace()} min per {GetDistanceType()}";
    }


}