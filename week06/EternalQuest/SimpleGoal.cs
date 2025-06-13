class SimpleGoal : Goal
{
    private bool completed;

    public override bool IsComplete => completed;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        completed = false;
    }

    public override int RecordEvent()
    {
        if (!completed)
        {
            completed = true;
            return Points;
        }
        return 0;
    }

    public override string GetStatus() => $"[{(completed ? "X" : " ")}] {Name}";

    public override string Serialize() => $"SimpleGoal|{Name}|{Description}|{Points}|{completed}";
}
