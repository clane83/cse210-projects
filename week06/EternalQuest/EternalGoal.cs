using System;

public class EternalGoal : Goal{

    public EternalGoal(string shortName, string description, string points) : base(shortName, description, points) {
        
    }
    public override bool IsComplete() {
        return false;
    }

    public override string RecordEvent() {
       return "[ ]";
    }

    public override string GetStringRepresentation() {
        return $"{RecordEvent()}|{GetShortName()}|{GetDescription()}|points: {GetPoints()}";
    }
}