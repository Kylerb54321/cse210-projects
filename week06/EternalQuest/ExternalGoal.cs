class EternalGoal : Goal
{
    public override bool IsComplete => false;

    public EternalGoal(string name, string description, int points)
        : base(name, description, points) { }

    public override int RecordEvent() => Points;

    public override string GetStatus() => $"[∞] {Name}";

    public override string Serialize() => $"EternalGoal|{Name}|{Description}|{Points}";
}
