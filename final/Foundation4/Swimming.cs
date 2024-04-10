public class Swimming : Activity
{
    private int _numOfLaps;

    public Swimming(DateTime date, float lengthInMins, int numOfLaps) : base(date, lengthInMins)
    {
        _activityType = "Swimming";
        _numOfLaps = numOfLaps;
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