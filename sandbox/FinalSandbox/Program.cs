class Program
{
   
    public static void Main(string[] args)
    {
        
    Console.Clear();
    int x = 10;
    string name = (x>10)?"jack":"javk";
    Console.WriteLine(name);

    string? name2 = null;
    int? length = name2?.Length;

    Console.WriteLine(length);




    }
}
