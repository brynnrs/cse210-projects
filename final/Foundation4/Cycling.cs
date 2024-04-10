public class Cycling : Activity
{
    private float _speed;

    public Cycling(DateTime date, float lengthInMins, float speed) : base(date, lengthInMins)
    {
        _activityType = "Cycling";
        _speed = speed;
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