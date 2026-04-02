using System.ComponentModel.Design;

abstract class Activity
{
    private double _minutes;
    private string _date;

    public double GetMinutes()
    {
        return _minutes;
    }
    public Activity(double minutes, string date)
    {
        _minutes = minutes;
        _date = date;
    }

    abstract public double GetDistance();
    abstract public double GetSpeed();
    abstract public double GetPace(); 

    public string GetSummary()
    {
        return $"{_date} {GetType().Name} ({_minutes} min): Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}