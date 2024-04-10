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
        double distance = _lengthInMins / GetPace();
        return distance;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        double pace = 60 / GetSpeed();
        return pace;
    }
}