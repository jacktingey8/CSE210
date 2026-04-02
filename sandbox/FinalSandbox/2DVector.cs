class Vector{
private int X;
private int Y;

public Vector(int x, int y){X=x;Y=y;}

public string GetVectorInfo(){return $"X:{X} - Y:{Y}";}

public static Vector operator +(Vector v1, Vector v2)
{
    return new Vector(v1.X+v2.X,v1.Y+v2.Y);

}

public static bool operator ==(Vector v1, Vector v2)
{
    return v1.X == v2.X && v1.Y == v2.Y;
}

public static bool operator !=(Vector v1, Vector v2)
{
    return v1.X != v2.X || v1.Y != v2.Y;
}


}