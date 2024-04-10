using System.Runtime.CompilerServices;

public abstract class Activity
{
    protected string _activityType = "Activity";
    protected DateTime _date;
    protected float _lengthInMins;

    public Activity(DateTime date, float lengthInMins)
    {
        _date = date;
        _lengthInMins = lengthInMins;       
    }
    public abstract double CalculateDistance();
    public abstract double CalculateSpeed();
    public abstract double CalculatePace();

    public string GetSummary()
    {
        return $"{_date} {_activityType} ({_lengthInMins} min)- Distance: {CalculateDistance()} miles, Speed: {CalculateSpeed()} mph, Pace: {CalculatePace()} min per mile";
    }
}