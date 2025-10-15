public class SwimmingActivity : Activity
{
    private double _laps;

    public SwimmingActivity(int minutes, double laps) : base(minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return ((_laps * 50) / 1000) * 0.62;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / _minutes) * 60;
    }

    public override double GetPace()
    {
        return _minutes / GetDistance();
    }
}