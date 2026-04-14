public class Cycling : Activity
{
    private int _speed;

    public Cycling(string date, int minutes, int speed) : base(date, minutes)
    {
        _speed = speed;
    }
    public override double GetDistance()
    {
        return _speed * (GetMinutes() / 60.0);
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        return 60.0 / _speed;
    }
    

}