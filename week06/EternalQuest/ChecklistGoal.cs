using System.ComponentModel.DataAnnotations.Schema;

public class ChecklistGoal : Goal
{
    private int _target;
    private int _timesCompleted;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _timesCompleted = 0;
    }

    public ChecklistGoal(string name, string description, int points, int target, int bonus, int timesCompleted) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _timesCompleted = timesCompleted;
    }

    public int GetBonusPoints()
    {
        return _bonus;
    }

    public override void RecordEvent(GoalManager manager)
    {
        _timesCompleted++;
        int pointsEarned = _points;
        if (_timesCompleted == _target)
        {
            pointsEarned += _bonus;
        }
        Console.WriteLine($"\nGreat Job!!\nYou earned {pointsEarned} more points!");
        manager.AddPoints(pointsEarned);
    }

    public override bool IsComplete()
    {
        bool isComplete = false;
        if (_timesCompleted >= _target)
        {
            isComplete = true;
        }
        return isComplete;
    }

    public override string GetStringDetails()
    {
        string mark = " ";
        if (IsComplete())
        {
            mark = "X";
        }
        return $"[{mark}] {_name} ({_description}) ~ Progress: {_timesCompleted}/{_target}";
    }

    public override string GetRepresentationString()
    {
        return $"ChecklistGoal{_delim}{_name}{_delim}{_description}{_delim}{_points}{_delim}{_bonus}{_delim}{_target}{_delim}{_timesCompleted}";
    }
}