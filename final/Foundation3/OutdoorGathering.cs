public class OutdoorGathering : Event
{
    private string _weather;

    public OutdoorGathering(
        string weather,
        string eventTitle, 
        string description, 
        string date, 
        string time, 
        Address address
        ) : base (eventTitle, description, date, time, address)
        {
            _eventType = "Outdoor Gathering";
            _weather = weather;
        }
    public string GetFullDetails()
    {
        return $"Event Type: {_eventType}\n{GetStandardDetails()}\nWeather Forecast: {_weather}";
    }
  
}