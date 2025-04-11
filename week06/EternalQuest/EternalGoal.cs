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

    public override string GetDetailsString() {
        return $"{RecordEvent()} {base.GetShortName()} / {base.GetDescription()} / {base.GetPoints()}/  {IsComplete()}";
    }

    public override string GetStringRepresentation() {
        return $"EternalGoal|{GetShortName()}|{GetDescription()}|{GetPoints()}|{IsComplete()}";
    }
}