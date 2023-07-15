using System;

public abstract class Goal
{
    public string Title { get; private set; }
    public int Points { get; private set; }

    protected Goal(string title, int points)
    {
        Title = title;
        Points = points;
    }

    public abstract void MarkComplete();

    public abstract string GetProgress();
}