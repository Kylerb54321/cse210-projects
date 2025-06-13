using System;
using System.Collections.Generic;
using System.IO;

class GoalManager
{
    private List<Goal> goals = new();
    private int totalScore = 0;

    public void AddGoal(Goal goal) => goals.Add(goal);

    public void RecordEvent(int goalIndex)
    {
        int earned = goals[goalIndex].RecordEvent();
        totalScore += earned;
        Console.WriteLine($"You earned {earned} points! Total: {totalScore}");
    }

    public void DisplayGoals()
    {
        for (int i = 0; i < goals.Count; i++)
            Console.WriteLine($"{i + 1}. {goals[i].GetStatus()}");
    }

    public void ShowScore() => Console.WriteLine($"Current Score: {totalScore}");

    public void SaveGoals(string filePath)
    {
        using StreamWriter writer = new(filePath);
        writer.WriteLine(totalScore);
        foreach (var goal in goals)
            writer.WriteLine(goal.Serialize());
    }

    public void LoadGoals(string filePath)
    {
        goals.Clear();
        var lines = File.ReadAllLines(filePath);
        totalScore = int.Parse(lines[0]);
        foreach (var line in lines[1..])
        {
            var parts = line.Split('|');
            switch (parts[0])
            {
                case "SimpleGoal":
                    var sg = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                    if (bool.TryParse(parts[4], out var done)) if (done) sg.RecordEvent();
                    goals.Add(sg);
                    break;
                case "EternalGoal":
                    goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                    break;
                case "ChecklistGoal":
                    var cg = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[5]), int.Parse(parts[6]));
                    for (int i = 0; i < int.Parse(parts[4]); i++) cg.RecordEvent();
                    goals.Add(cg);
                    break;
            }
        }
    }
}
