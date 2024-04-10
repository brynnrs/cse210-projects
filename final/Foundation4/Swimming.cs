public class Swimming : Activity
{
    private int _numOfLaps;

    public Swimming(DateTime date, float lengthInMins, int numOfLaps) : base(date, lengthInMins)
    {
        _activityType = "Swimming";
        _numOfLaps = numOfLaps;
    }

    public override double GetDistance()
    {
        return 0;
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