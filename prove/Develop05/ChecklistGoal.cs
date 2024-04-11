public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string shortName, string shortDescription, string points, int target, int bonus) : base(shortName, shortDescription, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted += 1;
    }

    public override bool isComplete()
    {
        return false;
    }

    public override string GetDetailsString()
    {
        return "";
    }
    public override string GetStringRepresentation()
    {
        return "";
    }
}
