using System;
using System.Threading;

public abstract class MindfulnessActivity
{
    protected int duration;
    protected string activityName;

    protected MindfulnessActivity(string activityName)
    {
        this.activityName = activityName;
    }

    public void Start()
    {
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine($"Starting {activityName} activity");
        Console.WriteLine("--------------------------------------------------");
        SetDuration();
        ShowStartingMessage();
        Pause(3);
        DoActivity();
        ShowFinishingMessage();
        Pause(3);
    }

    protected void SetDuration()
    {
        Console.Write("Enter the duration in seconds: ");
        duration = int.Parse(Console.ReadLine());
    }

    protected void ShowStartingMessage()
    {
        Console.WriteLine($"This activity will help you {activityName.ToLower()} for {duration} seconds.");
    }

    protected abstract void DoActivity();

    protected void ShowFinishingMessage()
    {
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine($"You have completed the {activityName} activity for {duration} seconds.");
        Console.WriteLine("Good job!");
        Console.WriteLine("--------------------------------------------------");
    }

    protected void Pause(int seconds)
    {
        for (int i = seconds; i >= 1; i--)
        {
            Console.Write($"\rPausing... {i} ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}