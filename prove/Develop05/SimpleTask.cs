public class SimpleTask : Goal
{
    public SimpleTask(string title, int points) : base(title, points)
    {
    }

    public override void MarkComplete()
    {
        // For simple tasks, the goal is marked complete
    }

    public override string GetProgress()
    {
        return "[X]"; // Indicate that the simple task is completed
    }
}