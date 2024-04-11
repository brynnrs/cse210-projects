public class Running : Activity
{
    private double _distance;

    public Running(DateTime date, double activityMins, double distance) : base(date, activityMins)
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
        double speed = 60 / GetPace();
        return speed;
    }

    public override double GetPace()
    {
        double pace = _activityMins / GetDistance();
        return pace;
    }

}