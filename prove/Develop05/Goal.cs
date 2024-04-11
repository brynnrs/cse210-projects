using System;

public abstract class Goal
{
    private string _shortName = "";
    private string _shortDescription = "";
    protected string _points;

    public Goal(string shortName, string shortDescription, string points)
    {
        _shortName = shortName;
        _shortDescription = shortDescription;
        _points = points;
    }

    public abstract void RecordEvent();

    public abstract bool isComplete();

    public virtual string GetDetailsString()
    {
        return "";
    }

    public abstract string GetStringRepresentation();
}
