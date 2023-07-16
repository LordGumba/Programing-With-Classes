using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address
        {
            Street = "123 Main St",
            City = "New York",
            State = "NY",
            Country = "USA"
        };

        Event genericEvent = new Event("Generic Event", "A generic event description", DateTime.Now, TimeSpan.FromHours(2), address1);

        Lecture lectureEvent = new Lecture("Exciting Lecture", "An exciting lecture description", DateTime.Now, TimeSpan.FromHours(1), address1, "John Smith", 50);

        Reception receptionEvent = new Reception("Grand Reception", "A grand reception description", DateTime.Now, TimeSpan.FromHours(3), address1, "rsvp@example.com");

        OutdoorGathering outdoorGatheringEvent = new OutdoorGathering("Picnic in the Park", "A picnic in the park description", DateTime.Now, TimeSpan.FromHours(4), address1, "Sunny and clear skies");

        DisplayEventDetails(genericEvent);
        DisplayEventDetails(lectureEvent);
        DisplayEventDetails(receptionEvent);
        DisplayEventDetails(outdoorGatheringEvent);
    }

    static void DisplayEventDetails(Event ev)
    {
        Console.WriteLine("=== Standard Details ===");
        Console.WriteLine(ev.GetStandardDetails());

        Console.WriteLine("\n=== Full Details ===");
        Console.WriteLine(ev.GetFullDetails());

        Console.WriteLine("\n=== Short Description ===");
        Console.WriteLine(ev.GetShortDescription());

        Console.WriteLine("\n==========================\n");
    }
}