public class OutdoorGathering : Event
{
    public string WeatherForecast { get; set; }

    public OutdoorGathering(string title, string description, DateTime date, TimeSpan time, Address location, string weatherForecast)
        : base(title, description, date, time, location)
    {
        WeatherForecast = weatherForecast;
    }

    public override string GetFullDetails()
    {
        return base.GetFullDetails() + $"\nEvent Type: Outdoor Gathering\nWeather Forecast: {WeatherForecast}";
    }

    public override string GetShortDescription()
    {
        return $"Event Type: Outdoor Gathering, Title: {Title}, Date: {Date.ToShortDateString()}";
    }
}