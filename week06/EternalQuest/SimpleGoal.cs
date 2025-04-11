using System;

public class SimpleGoal : Goal {
    private bool _isComplete = false;

    public SimpleGoal(string shortName, string description, string points, bool isComplete) : base(shortName, description, points) {
        
    }

    public override bool IsComplete() {
       return _isComplete;
    }

    public void SetComplete(bool complete)
    {
        _isComplete = complete;
    }


    public override string RecordEvent() {
        if (_isComplete){
            return "[X]";
        } else {
            return "[ ]";
        }
        
    }

//goal format for file
    public override string GetStringRepresentation() {
        return $"SimpleGoal|{GetShortName()}|{GetDescription()}|{GetPoints()}|{_isComplete}";
    }
}