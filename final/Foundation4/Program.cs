using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2024, 07, 22), 30, 3.0),
            new Cycling(new DateTime(2024, 07, 23), 30, 12.0),
            new Swimming(new DateTime(2024, 07, 24), 30, 40)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}