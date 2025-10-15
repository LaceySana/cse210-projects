public class CyclingActivity : Activity
{
    private double _speed;

    public CyclingActivity(int minutes, double speed) : base(minutes)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return (_minutes / 60.0) * _speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }
}