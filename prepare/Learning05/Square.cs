using System.Reflection.Metadata.Ecma335;

class Sqaure : Shape
{
    private double _side;

   public  Sqaure(double side, string color) : base(color) {_side=side;}
    public override double GetArea()
    {
        return _side * _side;
    }
}