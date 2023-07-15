public class EternalGoal : Goal
{
    private int timesCompleted;

    public EternalGoal(string title, int points) : base(title, points)
    {
        timesCompleted = 0;
    }

    public override void MarkComplete()
    {
        timesCompleted++;
    }

    public override string GetProgress()
    {
        return $"Completed {timesCompleted} time(s)"; // Show the number of times the eternal goal is completed
    }
}