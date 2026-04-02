using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running running = new Running("2024-06-01", 30, 3);
        activities.Add(running);

        Swimming swimming = new Swimming("2024-06-02", 45, 20);
        activities.Add(swimming);

        Biking biking = new Biking("2024-06-03", 60, 15);
        activities.Add(biking);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}