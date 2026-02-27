using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(0, 100);
        bool done= false;
        do
        {
        Console.Write("guess: ");
        int guess=int.Parse(Console.ReadLine());
        if (guess>magicNumber){Console.WriteLine("lower");}
        else if (guess<magicNumber){Console.WriteLine("higher");}
        else {Console.WriteLine("Correct"); done = true;}
        
        }while (! done);
    }
}