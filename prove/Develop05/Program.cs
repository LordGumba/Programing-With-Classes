using System;
using System.Collections.Generic;

class Program
{
    static List<Goal> goals = new List<Goal>();
    static int score = 0;

    static void Main(string[] args)
    {
        LoadGoals(); // Load goals and score from a file

        while (true)
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Eternal Quest Program");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. Record an event");
            Console.WriteLine("3. Show goals");
            Console.WriteLine("4. Show score");
            Console.WriteLine("5. Exit");
            Console.WriteLine("--------------------------------------------------");
            Console.Write("Enter your choice (1-5): ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    RecordEvent();
                    break;
                case "3":
                    ShowGoals();
                    break;
                case "4":
                    ShowScore();
                    break;
                case "5":
                    SaveGoals(); // Save goals and score to a file
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void CreateGoal()
    {
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Create a new goal");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Goal types:");
        Console.WriteLine("1. Simple goal");
        Console.WriteLine("2. Eternal goal");
        Console.WriteLine("3. Checklist goal");
        Console.WriteLine("--------------------------------------------------");
        Console.Write("Enter the goal type (1-3): ");

        string input = Console.ReadLine();

        Console.Write("Enter the goal title: ");
        string title = Console.ReadLine();

        Console.Write("Enter the points for completing the goal: ");
        int points = int.Parse(Console.ReadLine());

        switch (input)
        {
            case "1":
                goals.Add(new SimpleTask(title, points));
                break;
            case "2":
                goals.Add(new EternalGoal(title, points));
                break;
            case "3":
                Console.Write("Enter the target count for the checklist goal: ");
                int targetCount = int.Parse(Console.ReadLine());
                goals.Add(new ChecklistGoal(title, points, targetCount));
                break;
            default:
                Console.WriteLine("Invalid goal type. Please try again.");
                break;
        }
    }

    static void RecordEvent()
    {
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Record an event");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Select a goal to record an event:");

        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].Title}");
        }

        Console.WriteLine("--------------------------------------------------");
        Console.Write("Enter the goal number: ");

        int goalNumber = int.Parse(Console.ReadLine()) - 1;

        if (goalNumber < 0 || goalNumber >= goals.Count)
        {
            Console.WriteLine("Invalid goal number. Please try again.");
            return;
        }

        Goal goal = goals[goalNumber];
        goal.MarkComplete();
        score += goal.Points + (goal is ChecklistGoal checklistGoal && checklistGoal.IsComplete() ? checklistGoal.GetBonusPoints() : 0);

        Console.WriteLine("Event recorded successfully!");
    }

    static void ShowGoals()
    {
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Goals");
        Console.WriteLine("--------------------------------------------------");

        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].Title} {goals[i].GetProgress()}");
        }
    }

    static void ShowScore()
    {
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine($"Score: {score}");
    }

    static void LoadGoals()
    {
        // Load goals and score from a file or any other storage mechanism
    }

    static void SaveGoals()
    {
        // Save goals and score to a file or any other storage mechanism
    }
}