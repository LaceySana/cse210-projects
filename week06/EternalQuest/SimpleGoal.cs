public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent(GoalManager manager)
    {
        _isComplete = true;
        Console.WriteLine($"\nGreat Job!!\nYou earned {_points} more points!");
        manager.AddPoints(_points);
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetRepresentationString()
    {

        return $"SimpleGoal{_delim}{_name}{_delim}{_description}{_delim}{_points}{_delim}{_isComplete}";
    }
}