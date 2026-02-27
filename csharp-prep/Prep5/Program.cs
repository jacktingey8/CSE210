using System;
using System.Globalization;

class Program
{
public static void Welcome(){Console.WriteLine("welcome to the program");}

public static string Name()
    {
        Console.Write("enter name:");
        string userName=Console.ReadLine();
        return (userName);
    }

public static int favNumber()
    {
        Console.Write("favorite number:");
        int number = int.Parse(Console.ReadLine());
        return(number);
    }

public static void birthYear(out int age)
{Console.Write("birthyear:");
age=int.Parse(Console.ReadLine());
}
public static int squareNumber(int number){return(number*number);}
public static void displayResults(string name,int favoriteNumber, int birthyear, int squareNumber)
    {
        Console.WriteLine($"your name is {name}");
        Console.WriteLine($"your favorite number is {favoriteNumber}");
        Console.WriteLine($"your birthyear is {birthyear}");
        Console.WriteLine($"your favorite number squared is {squareNumber}");
        Console.WriteLine($"you are {2026-birthyear} years old");
    }
    static void Main(string[] args)
    {
        Welcome();
        string userName=Name();
        int favoritNumber=favNumber();
        int year;
        birthYear(out year);
        int squared = squareNumber(favoritNumber);
        displayResults(userName,favoritNumber,year,squared);
        
    }
}
