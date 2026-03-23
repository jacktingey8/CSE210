using System;

class Program
{
    static void Main(string[] args)
    {
        
        Circle circle = new Circle(3,"blue");
        Rectangle rectangle = new Rectangle(4,3,"yellow");
        Sqaure square = new Sqaure(7,"red");

        List<Shape> shapeList = new List<Shape>(){circle,rectangle,square};
        
        foreach (Shape shapes in shapeList)
        {
            Console.WriteLine(shapes);
            Console.WriteLine(shapes.GetColor());
            Console.WriteLine(shapes.GetArea());
        }




    }
}