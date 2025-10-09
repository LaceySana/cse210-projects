public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected string _delim = "||";

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public string GetName()
    {
        return _name;
    }

    public int GetPoints()
    {
        return _points;
    }

    public string GetDelimiter()
    {
        return _delim;
    }

    public abstract void RecordEvent(GoalManager manager);

    public abstract bool IsComplete();

    public abstract string GetRepresentationString();

    public virtual string GetStringDetails()
    {
        string mark = " ";
        if (IsComplete())
        {
            mark = "X";
        }
        return $"[{mark}] {_name} ({_description})";
    }
}