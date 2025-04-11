using System;

public abstract class Goal {
    private string _shortName {get;}
    private string _description {get;}
    private int _points {get;}

    public Goal(string shortName, string description, string points) {
        _shortName = shortName;
        _description = description;
        _points = int.Parse(points);
    }

    public string GetShortName() {
        return _shortName;
    }

    public string GetDescription() {
        return _description;
    }

    public  int GetPoints() {
        return _points;
    }

    public virtual string GetDetailsString() {
        return $"{RecordEvent()} {_shortName} / {_description} / {_points}";
    }

    public abstract string GetStringRepresentation();

    public abstract string RecordEvent();

    public abstract bool IsComplete();


}