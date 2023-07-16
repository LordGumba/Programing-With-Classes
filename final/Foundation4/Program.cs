using System;
using System.Collections.Generic;

namespace FitnessTracker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Activity> activities = new List<Activity>();

            Running runningActivity = new Running
            {
                Date = new DateTime(2022, 11, 3),
                Length = 30,
                Distance = 3.0
            };
            activities.Add(runningActivity);

            Cycling cyclingActivity = new Cycling
            {
                Date = new DateTime(2022, 11, 3),
                Length = 30,
                Speed = 6.0
            };
            activities.Add(cyclingActivity);

            Swimming swimmingActivity = new Swimming
            {
                Date = new DateTime(2022, 11, 3),
                Length = 30,
                Laps = 20
            };
            activities.Add(swimmingActivity);

            foreach (Activity activity in activities)
            {
                string summary = activity.GetSummary();
                Console.WriteLine(summary);
            }
        }
    }
}