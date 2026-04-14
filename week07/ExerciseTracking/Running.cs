public class Running : Activity
{
    private int _distance;

    public Running(string date, int minutes, int distance) : base(date, minutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return (_distance /(double)GetMinutes()) * 60.0;
    }
    public override double GetPace()
    {
        return 60.0 / (double)_distance;
    }
    





}