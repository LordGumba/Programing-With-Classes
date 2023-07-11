using System;

public class Breathing : MindfulnessActivity
{
    private Breathing() : base("Breathing")
    {
    }

    protected override void DoActivity()
    {
        int breathInDuration = duration / 2;
        int breathOutDuration = duration / 2;

        for (int i = 1; i <= duration; i++)
        {
            if (i % 2 == 1)
            {
                Console.WriteLine("Breathe in...");
            }
            else
            {
                Console.WriteLine("Breathe out...");
            }

            Pause(1);
        }
    }
}