public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points) { }

    public override void RecordEvent(GoalManager manager)
    {
        Console.WriteLine($"\nGreat Job!!\nYou earned {_points} more points!");
        manager.AddPoints(_points);
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetRepresentationString()
    {
        return $"EternalGoal{_delim}{_name}{_delim}{_description}{_delim}{_points}";
    }
}