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
        double speed = _distance / _lengthInMins * 60;
        return speed;
    }

    public override double GetPace()
    {
        double pace = 60 / GetSpeed();
        return pace;
    }

}