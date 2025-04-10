using System;

public class SimpleGoal : Goal {
    private bool _isComplete;

    public SimpleGoal(string shortName, string description, string points, bool isComplete) : base(shortName, description, points) {
        _isComplete = isComplete;
    }

    public override bool IsComplete() {
        return _isComplete;
    }

    public override string RecordEvent() {
        if (_isComplete){
            return "[X]";
        } else {
            return "[ ]";
        }
        
    }

    public override string GetStringRepresentation() {
        return $"{RecordEvent()}|{GetShortName()}|{GetDescription()}|points: {GetPoints()}";
    }
}