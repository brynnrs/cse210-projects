using System.Net.Sockets;

public class Event
{
    protected string _eventType = "Event";
    protected string _eventTitle;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;

    public Event(string eventTitle, string description, string date, string time, Address address)
    {
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }
    public string GetStandardDetails()
    {
        return $"Title: {_eventTitle}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address.GetAddress()}";
    }

    public string GetShortDescription()
    {
        return $"Event Type: {_eventType}\nTitle: {_eventTitle}\nDate: {_date}";
    }
}