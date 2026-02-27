using System;
using System.Globalization;
using System.Reflection.PortableExecutable;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {   
        List<int>numberList = new List<int>();
        bool done = false;
        do{
        Console.Write("enter number:");
        int numberForList=int.Parse(Console.ReadLine());
        numberList.Add(numberForList);
        if (numberForList == 0){done= true;}
        }while (!done);
        foreach (int i in numberList){Console.WriteLine(i);}
        int sum = 0;
        foreach (int i in numberList){sum=i+sum;}
        int avg = sum/numberList.Count;
        int max= numberList.Max();
        Console.WriteLine($"Sum={sum} Average={avg} Maximum={max}");
    }   
}