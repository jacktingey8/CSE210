using System;

class Program
{
    static void Main(string[] args)
    {
    Address address1= new Address("street","city","state","country");
    Address address2= new Address("stret","citty","staet","conutry");
    Address address3= new Address("strett","citie","sate","cocontry");

    Lecture lecture1 = new Lecture("Lecture Title", "Lecture Description", "DATE", "10AM", address1, "Speaker Name", 100);
    Reception reception1 = new Reception("Reception Title", "Reception Description", "DATE", "10AM", address2, "rsvpEmail");
    Outdoor outdoor1= new Outdoor("Outdoor Title", "Outdoor Description", "DATE", "10AM", address3, "Weathery");
    List<Event> events = new List<Event>{lecture1, reception1, outdoor1};

    foreach (Event i in events)
        {   Console.Clear();
            Console.WriteLine(i);
            Console.WriteLine();
            Console.WriteLine("STANDARD DETAILS");
            Console.WriteLine(i.GetStandardDetails());
            Console.WriteLine();
            Console.WriteLine("FULL DETAILS");
            Console.WriteLine(i.GetFullDetails());
            Console.WriteLine();
            Console.WriteLine("SHORT DESCRIPTION");
            Console.WriteLine(i.GetShortDescription());
            Console.WriteLine();
            Console.ReadLine();
        }
}}