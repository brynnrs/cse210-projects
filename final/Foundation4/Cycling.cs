public class Cycling : Activity
{
    private float _speed;

    public Cycling(DateTime date, float lengthInMins, float speed) : base(date, lengthInMins)
    {
        _activityType = "Cycling";
        _speed = speed;
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