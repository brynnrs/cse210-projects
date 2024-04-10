public class Reception : Event
{
    private string _rsvpEmail;

    public Reception(
        string rsvpEmail, 
        string eventTitle, 
        string description, 
        string date, 
        string time, 
        Address address
        ) : base (eventTitle, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
        _eventType = "Reception";
    }
    public string GetFullDetails()
    {
        return $"Event Type: {_eventType}\n{GetStandardDetails()}\nRSVP: {_rsvpEmail}";
    }
}