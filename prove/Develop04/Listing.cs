using System;
using System.Collections.Generic;

public class Listing : MindfulnessActivity
{
    private List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private Listing() : base("Listing")
    {
    }

    protected override void DoActivity()
    {
        Random random = new Random();
        int count = 0;

        Console.WriteLine(prompts[random.Next(prompts.Count)]);

        DateTime startTime = DateTime.Now;
        while (DateTime.Now.Subtract(startTime).TotalSeconds < duration)
        {
            string item = Console.ReadLine();
            if (string.IsNullOrEmpty(item))
                break;

            count++;
        }

        Console.WriteLine($"You listed {count} items.");
    }
}