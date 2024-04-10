using System.Runtime.CompilerServices;

public abstract class Activity
{
    protected string _activityType = "Activity";
    protected DateOnly _date;
    protected float _activityMins;

    public Activity(DateOnly date, float activityMins)
    {
        _date = date;
        _activityMins = activityMins;       
    }
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public string GetSummary()
    {
        return $"{_date} {_activityType} ({_activityMins} min)- Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}