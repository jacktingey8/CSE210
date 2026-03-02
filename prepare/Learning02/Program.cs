using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

    Job job1 = new Job();
    job1._jobTitle= "Software Engineer";
    job1._company="Apple";
    job1._startYear=2007;
    job1._endYear= 2017;
    job1.displayInfo();

    Job job2= new Job();
    job2._jobTitle= "Sotfwaer Engeiner";
    job2._company="Apble";
    job2._startYear=2018;
    job2._endYear= 2021;
    job2.displayInfo();

    Resume resume1= new Resume();
    resume1._name="Jack Tingey";
    resume1._jobs.Add(job1);
    resume1._jobs.Add(job2);
    resume1.DisplayResume();

    }
}