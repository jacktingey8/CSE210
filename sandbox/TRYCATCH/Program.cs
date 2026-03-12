class Program
{
    public static int GetAge(){
        int age = 0;

        bool done = false;
        while(!done){
        try
        {    
        Console.Write("age: ");

        age = int.Parse(Console.ReadLine());

        if (age>0 && age<100){done= true;}

        else {throw new Exception("invalid age");}
        }
        catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("invalid age");
            }
        }
         return age;
        }



    public static void Main(string[] args)
    {
        Console.WriteLine($"Your age is {GetAge()}");
    }
}