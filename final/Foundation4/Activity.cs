using System.Runtime.CompilerServices;

public abstract class Activity
{
    protected string _activityType = "Activity";
    protected DateTime _date;
    protected double _activityMins;

    public Activity(DateTime date, double activityMins)
    {
        _date = date;
        _activityMins = activityMins;       
    }
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} {_activityType} ({_activityMins} min)- Distance: {GetDistance().ToString("N1")} miles, Speed: {GetSpeed().ToString("N1")} mph, Pace: {GetPace().ToString("N1")} min per mile";
    }
}