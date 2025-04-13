using System;

//Swimming: number of laps
public class Swimming : Exercise {

    public Swimming(double distance, int minutes, int distanceType ) : base (distance, minutes, distanceType){

    }

    public virtual double GetSwimmingDistance(){
        double laps = base.GetDistance();
        // Distance (km) = swimming laps * 50 / 1000
        // Distance (miles) = swimming laps * 50 / 1000 * 0.62
        if (GetDistanceType() == "miles"){
            return laps * 50 / 1000 * 0.62;
        } else {
            return laps * 50 / 1000;
        }

    }

    public override double GetSpeed(){
    // Speed (mph or kph) = (distance / minutes) * 60
    // Speed = 60 / pace
        return (GetSwimmingDistance() / GetMinutes()) * 60;
    }

    public override double GetPace(){
    // Pace (min per mile or min per km)= minutes / distance
    // Pace = 60 / speed
        return GetMinutes() / GetSpeed();
    }



    public override string GetDetailsString() {
        string formattedDate = GetDate().ToString("dd MMM yyyy");
        //03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
        return $"{formattedDate} Swimming ({GetMinutes()} min) - Distance {GetSwimmingDistance():0.00} {GetDistanceType()}, Speed {GetSpeed():0.00} {GetDistanceAbbreviation()}, Pace: {GetPace():0.00} min per {GetDistanceType()}";
    }


}




    