public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }
    
    public override double GetDistance()
    {
        return _laps * 50 / 1000.0; // for Km distance

    }
    public override double GetSpeed()
    {
        return ((double)GetDistance() / (double)GetMinutes()) * 60; // using Km distance
    }
    public override double GetPace()
    {
        return (double)GetMinutes() / (double)GetDistance();
    }
}