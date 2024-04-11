public class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime date, double activityMins, double speed) : base(date, activityMins)
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