class Swimming : Activity
{
    private double _laps;

    public Swimming(string date,double duration, double laps) : base(duration, date)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000; 
    }

    public override double GetSpeed()
    {
        double distance = GetDistance();
        double timeInHours = GetMinutes() / 60; 
        return distance / timeInHours; 
    }

    public override double GetPace()
    {
        double distance = GetDistance();
        double timeInMinutes = GetMinutes(); 
        return timeInMinutes / distance; 
    }
}