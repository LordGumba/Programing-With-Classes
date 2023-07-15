public class ChecklistGoal : Goal
{
    private int targetCount;
    private int timesCompleted;

    public ChecklistGoal(string title, int points, int targetCount) : base(title, points)
    {
        this.targetCount = targetCount;
        timesCompleted = 0;
    }

    public override void MarkComplete()
    {
        timesCompleted++;
    }

    public override string GetProgress()
    {
        return $"Completed {timesCompleted}/{targetCount} times"; // Show the current completion progress of the checklist goal
    }

    public bool IsComplete()
    {
        return timesCompleted >= targetCount;
    }

    public int GetBonusPoints()
    {
        return IsComplete() ? Points : 0;
    }
}