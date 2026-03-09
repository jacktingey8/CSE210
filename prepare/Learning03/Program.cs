using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction = new Fraction();
        Random random = new Random();

        for (int i=0; i < 20; i++)
        {
            fraction.SetTop(random.Next(50)); 
            fraction.SetBottom(random.Next(50)); 
            Console.WriteLine($"Fraction {i}: String: {fraction.GetFractionString()} Decimal: {fraction.GetFractionDecimal()} ");
        
        }

        
    }
}