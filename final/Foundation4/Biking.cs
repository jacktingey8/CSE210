class Biking : Activity
{
    private double _speed;

    public Biking(string date, double duration, double speed) : base(duration, date)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return _speed * GetMinutes() / 60; 
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