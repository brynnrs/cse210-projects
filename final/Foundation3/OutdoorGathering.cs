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
            _weather = weather;
            _eventType = "Outdoor Gathering";
        }
    public string GetFullDetails()
    {
        return $"Event Type: {_eventType}\n{GetStandardDetails()}\nWeather Forecast: {_weather}";
    }
  
}