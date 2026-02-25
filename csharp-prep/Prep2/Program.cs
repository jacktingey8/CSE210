using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("grade:");
        int grade = int.Parse(Console.ReadLine());
        string letterGrade;

        if (grade >=90){letterGrade = "A"; }
        else if (grade >=80 && grade <=90){letterGrade = "B"; }
        else if (grade >=70 && grade <=80){letterGrade = "C"; }
        else if (grade >=60 && grade <=70){letterGrade = "D"; }
        else {letterGrade = "F"; }
        Console.WriteLine($"Your Grade is {letterGrade}");
        if (letterGrade !="F"){Console.WriteLine("you have passed");}
        else {Console.WriteLine("you have failed");}
    }
}