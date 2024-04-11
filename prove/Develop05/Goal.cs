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

    public virtual void RecordEvent()
    {

    }

    public virtual bool isComplete()
    {
        return false;
    }

    public virtual string GetDetailsString()
    {
        return "";
    }

    public virtual string GetStringRepresentation()
    {
        return "";
    }
}
