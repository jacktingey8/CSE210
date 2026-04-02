using System.Data.Common;

class Program
{
   
    public static void Main(string[] args)
    {
        Vector vector1 = new Vector(10,11);
        Console.WriteLine(vector1.GetVectorInfo());

        Vector vector2 = new Vector(5,6);

        Vector vector3 = vector1 + vector2;
        Console.WriteLine(vector3.GetVectorInfo());

        Console.WriteLine(3+4);

    if(vector2 == vector3){Console.WriteLine("Equal");}
    else{Console.WriteLine("Not Equal");}


    // Console.Clear();
    // int x = 10;
    // string name = (x>10)?"jack":"javk";
    // Console.WriteLine(name);

    // string? name2 = null;
    // int? length = name2?.Length;

    // Console.WriteLine(length);




    }
}
