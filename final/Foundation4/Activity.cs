using System;

namespace FitnessTracker
{
    public abstract class Activity
    {
        public DateTime Date { get; set; }
        public int Length { get; set; }

        public abstract double GetDistance();
        public abstract double GetSpeed();
        public abstract double GetPace();

        public string GetSummary()
        {
            string activityType = GetType().Name;
            double distance = GetDistance();
            double speed = GetSpeed();
            double pace = GetPace();

            string summary = $"{Date:d MMM yyyy} {activityType} ({Length} min) - ";
            summary += $"Distance: {distance} miles, Speed: {speed} mph, Pace: {pace} min per mile";

            return summary;
        }
    }
}