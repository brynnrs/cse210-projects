public class Running : Activity
{
    private float _distance;

    public Running(DateTime date, float lengthInMins, float distance) : base(date, lengthInMins)
    {
        _activityType = "Running";
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return 0;
    }

    public override double GetPace()
    {
        return 0;
    }

}