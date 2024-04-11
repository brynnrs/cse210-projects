public class SimpleGoal : Goal
{
    private bool _isComplete;
    public SimpleGoal(string shortName, string shortDescription, string points) : base(shortName, shortDescription, points)
    {

    }
    
    public override void RecordEvent()
    {

    }

    public override bool isComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return "";
    }
}
