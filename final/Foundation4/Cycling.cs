public class Cycling : Activity
{
    private float _speed;

    public Cycling(DateOnly date, float activityMins, float speed) : base(date, activityMins)
    {
        _activityType = "Cycling";
        _speed = speed;
    }

    public override double GetDistance()
    {
        double distance = _activityMins / GetPace();
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