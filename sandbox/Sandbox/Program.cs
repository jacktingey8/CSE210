using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("age:");
        int age;
        age = int.Parse(Console.ReadLine());
        Console.WriteLine($"You are {age}");

        if (age <=100 && age != 19 && age !=0) Console.WriteLine("Ok");

        else if (age == 19 || age==0) Console.WriteLine("Alright");
        
        else Console.WriteLine("Yes");
        
    }
}