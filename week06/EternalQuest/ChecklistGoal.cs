using System;

public class ChecklistGoal : Goal {
    private int _amountCompleted = 0;
    private int _target;
    private int _bonus;
    private bool _isComplete = false;

    public ChecklistGoal(string shortName, string description,string amountCompleted, string target, string bonus, string points) : base(shortName, description, points) {
        _amountCompleted = int.Parse(amountCompleted);
        _target = int.Parse(target);
        _bonus = int.Parse(bonus);
    }

    public override string GetDetailsString() {
        return $"{RecordEvent()} {base.GetShortName()} / {base.GetDescription()} / {base.GetPoints()} / {_amountCompleted} out of {_target} completed / {_bonus}";
    }

    public void SetAmountCompleted(int completed) {
        _amountCompleted += completed;
        // return _amountCompleted;
    }

    public override bool IsComplete() {
        if (_amountCompleted >= _target){
            _isComplete = true;
            
        }
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
        return $"ChecklistGoal|{GetShortName()}|{GetDescription()}|{GetPoints()}|{_amountCompleted}|{_target}|{_bonus}";
    }

}