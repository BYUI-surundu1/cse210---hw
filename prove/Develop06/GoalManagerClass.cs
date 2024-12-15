using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> goals;
    public int TotalScore { get; private set; }

    public GoalManager()
    {
        goals = new List<Goal>();
        TotalScore = 0;
    }

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void RecordEvent(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < goals.Count)
        {
            TotalScore += goals[goalIndex].RecordEvent();
        }
    }

    public void DisplayGoals()
    {
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetDetailsString()}");
        }
    }

    public void SaveGoals(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (var goal in goals)
            {
                outputFile.WriteLine(goal.GetDetailsString());
            }
            outputFile.WriteLine($"TotalScore:{TotalScore}");
        }
    }

    public void LoadGoals(string fileName)
    {
        if (File.Exists(fileName))
        {
            string[] lines = File.ReadAllLines(fileName);
            foreach (string line in lines)
            {
                string[] parts = line.Split(':');
                if (parts[0] == "TotalScore")
                {
                    TotalScore = int.Parse(parts[1]);
                }
                else
                {
                    // Assuming the format is "Type:Name-Description"
                    string[] details = parts[1].Split('-');
                    if (parts[0] == "SimpleGoal")
                    {
                        goals.Add(new SimpleGoal(details[0], details[1], int.Parse(details[2])));
                    }
                    else if (parts[0] == "EternalGoal")
                    {
                        goals.Add(new EternalGoal(details[0], details[1], int.Parse(details[2])));
                    }
                    else if (parts[0] == "ChecklistGoal")
                    {
                        // Assuming an extended format for checklist goals
                        goals.Add(new ChecklistGoal(details[0], details[1], int.Parse(details[2]), int.Parse(details[3]), int.Parse(details[4])));
                    }
                }
            }
        }
    }
}
