using System;

public class ChecklistGoal : Goal {
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string shortName, string description, string amountCompleted, string target, string bonus, string points) : base(shortName, description, points) {
        _amountCompleted = int.Parse(amountCompleted);
        _target = int.Parse(target);
        _bonus = int.Parse(bonus);
    }

    public override string GetDetailsString() {
        return $"{RecordEvent()} {base.GetShortName()} / {base.GetDescription()} / {base.GetPoints()} / {_amountCompleted} out of {_target} completed / {_bonus}";
    }

    public override bool IsComplete() {
        if (_amountCompleted >= _target){
            return true;
        } else {
            return false;
        }
        
    }

    public override string RecordEvent() {
        if (_amountCompleted >= _target){
            return "[X]";
        } else {
            return "[ ]";
        }
    }

    public override string GetStringRepresentation() {
        return $"ChecklistGoal|{GetShortName()}|{GetDescription()}|{GetPoints()}|{_amountCompleted}|{_target}|{_bonus}";
    }

}