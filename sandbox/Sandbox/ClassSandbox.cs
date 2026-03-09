class Circle
{
    public double _radius;

    public Circle(){_radius = 1;}
    public Circle(double radius){SetRadius(radius);}
    public double GetRadius(){return _radius; }

    private void SetRadius(double radius)
    {
        if(radius < 0){Console.WriteLine("invalid Radius"); radius = 0; return;}
        _radius=radius;
    }

    public double GetArea(){return Math.PI * _radius * _radius;}

    public double GetDiameter(){return 2 * _radius;}

    public double GetCircumference(){return 2* Math.PI* _radius;}
}