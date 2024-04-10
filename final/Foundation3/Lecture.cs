using System.Diagnostics;

public class Lecture : Event
{
    private string _speaker;
    private int _capacityLimit;
    public Lecture (
        string speaker, 
        int capacityLimit, 
        string eventTitle, 
        string description, 
        string date, 
        string time, 
        Address address
        ) : base (eventTitle, description, date, time, address)
    {
        _speaker = speaker;
        _capacityLimit = capacityLimit;
        _eventType = "Lecture";
    }
    
    public string GetFullDetails()
    {
        return $"Event Type: {_eventType}\n{GetStandardDetails()}\nSpeaker: {_speaker}\nCapacity Limit: {_capacityLimit}";
    }
}