using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running running = new Running("2025-12-25", 30, 3);
        activities.Add(running);

        Swimming swimming = new Swimming("2026-01-01", 45, 20);
        activities.Add(swimming);

        Biking biking = new Biking("2026-01-05", 60, 15);
        activities.Add(biking);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}