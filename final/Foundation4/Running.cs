public class Running : Activity
{
    private float _distance;

    public Running(DateTime date, float lengthInMins, float distance) : base(date, lengthInMins)
    {
        _activityType = "Running";
        _distance = distance;
    }

    public override double CalculateDistance()
    {
        return 0;
    }

    public override double CalculateSpeed()
    {
        return 0;
    }

    public override double CalculatePace()
    {
        return 0;
    }

}