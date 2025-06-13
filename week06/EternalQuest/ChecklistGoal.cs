class ChecklistGoal : Goal
{
    private int targetCount;
    private int currentCount;
    private int bonusPoints;

    public override bool IsComplete => currentCount >= targetCount;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints)
        : base(name, description, points)
    {
        this.targetCount = targetCount;
        this.bonusPoints = bonusPoints;
        this.currentCount = 0;
    }

    public override int RecordEvent()
    {
        if (!IsComplete)
        {
            currentCount++;
            return Points + (IsComplete ? bonusPoints : 0);
        }
        return 0;
    }

    public override string GetStatus()
        => $"[{(IsComplete ? "X" : " ")}] {Name} - Completed {currentCount}/{targetCount} times";

    public override string Serialize()
        => $"ChecklistGoal|{Name}|{Description}|{Points}|{currentCount}|{targetCount}|{bonusPoints}";
}
