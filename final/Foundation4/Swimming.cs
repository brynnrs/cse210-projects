public class Swimming : Activity
{
    private int _numOfLaps;

    public Swimming(DateTime date, float activityMins, int numOfLaps) : base(date, activityMins)
    {
        _activityType = "Swimming";
        _numOfLaps = numOfLaps;
    }

    public override double GetDistance()
    {
        double distance = _numOfLaps * 50 / 1000;
        return distance;
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