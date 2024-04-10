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
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public string GetSummary()
    {
        return $"{_date} {_activityType} ({_lengthInMins} min)- Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}