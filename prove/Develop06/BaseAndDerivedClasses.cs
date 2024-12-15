using System;

public abstract class Goal
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Points { get; set; }

    public Goal(string name, string description, int points)
    {
        Name = name;
        Description = description;
        Points = points;
    }

    public abstract int RecordEvent();
    public abstract string GetDetailsString();
}

public class SimpleGoal : Goal
{
    public bool IsComplete { get; private set; }

    public SimpleGoal(string name, string description, int points) 
        : base(name, description, points)
    {
        IsComplete = false;
    }

    public override int RecordEvent()
    {
        if (!IsComplete)
        {
            IsComplete = true;
            return Points;
        }
        return 0;
    }

    public override string GetDetailsString()
    {
        return $"{Name} - {Description} (Complete: {IsComplete})";
    }
}

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) 
        : base(name, description, points) { }

    public override int RecordEvent()
    {
        return Points;
    }

    public override string GetDetailsString()
    {
        return $"{Name} - {Description}";
    }
}

public class ChecklistGoal : Goal
{
    public int TargetCount { get; set; }
    public int CurrentCount { get; set; }
    public int Bonus { get; set; }

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonus)
        : base(name, description, points)
    {
        TargetCount = targetCount;
        CurrentCount = 0;
        Bonus = bonus;
    }

    public override int RecordEvent()
    {
        CurrentCount++;
        if (CurrentCount >= TargetCount)
        {
            int totalPoints = Points + Bonus;
            Points = 0; // Prevent further points after completion
            return totalPoints;
        }
        return Points;
    }

    public override string GetDetailsString()
    {
        return $"{Name} - {Description} (Completed {CurrentCount}/{TargetCount} times)";
    }
}
