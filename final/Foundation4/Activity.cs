using System.Runtime.CompilerServices;

public class Activity
{
    protected DateTime _date;
    protected float _lengthInMins;

    public virtual float CalculateDistance()
    {
        return 0;
    }

    public virtual float CalculateSpeed()
    {
        return 0;
    }

    public virtual float CalculatePace()
    {
        return 0;
    }

    public string GetSummary()
    {
        return "";
    }
}