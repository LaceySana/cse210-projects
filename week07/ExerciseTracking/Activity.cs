public abstract class Activity
{
    private string _date;
    protected int _minutes;

    public Activity(int minutes)
    {
        DateTime dt = DateTime.Now;

        _date = dt.ToString("dd MMM yyyy");
        _minutes = minutes;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public string GetSummary()
    {
        string activityName = GetType().ToString();
        activityName = activityName.Remove(activityName.Length - 8);
        string summary = $"{_date} {activityName} ({_minutes} min)- Distance {Math.Round(GetDistance(), 2)} miles, Speed {Math.Round(GetSpeed(), 2)} mph, Pace {Math.Round(GetPace(), 2)} min per mile";
        return summary;
    }
}