public class Reception : Event
{
    public string RSVPEmail { get; set; }

    public Reception(string title, string description, DateTime date, TimeSpan time, Address location, string rsvpEmail)
        : base(title, description, date, time, location)
    {
        RSVPEmail = rsvpEmail;
    }

    public override string GetFullDetails()
    {
        return base.GetFullDetails() + $"\nEvent Type: Reception\nRSVP Email: {RSVPEmail}";
    }

    public override string GetShortDescription()
    {
        return $"Event Type: Reception, Title: {Title}, Date: {Date.ToShortDateString()}";
    }
}