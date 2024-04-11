public class EternalGoal : Goal 
{
    public EternalGoal(string shortName, string shortDescription, string points) : base(shortName, shortDescription, points)
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