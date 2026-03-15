using System;

class Program
{static void Main(string[] args)
{        
//  Assignment assignment = new Assignment("Jack", "subtraction");

// Console.WriteLine(assignment.GetSummary());

MathAssignment maths = new MathAssignment("Jack","nubmers","6489539853","359244242348");

Console.WriteLine(maths.GetSummary() +' '+ maths.GetHomeworkList());


WritingAssignment words = new WritingAssignment("jack","book","i killed mockingbird!");

Console.WriteLine(words.GetSummary()+ ' ' + words.GetWrtingInformation());














    }
}