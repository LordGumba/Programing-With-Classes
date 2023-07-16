public class Lecture : Event
{
    public string Speaker { get; set; }
    public int Capacity { get; set; }

    public Lecture(string title, string description, DateTime date, TimeSpan time, Address location, string speaker, int capacity)
        : base(title, description, date, time, location)
    {
        Speaker = speaker;
        Capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return base.GetFullDetails() + $"\nEvent Type: Lecture\nSpeaker: {Speaker}\nCapacity: {Capacity}";
    }

    public override string GetShortDescription()
    {
        return $"Event Type: Lecture, Title: {Title}, Date: {Date.ToShortDateString()}";
    }
}