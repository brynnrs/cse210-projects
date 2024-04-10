using System;

class Program
{
    static void Main(string[] args)
    {
        DateOnly date = DateOnly.FromDateTime(DateTime.Today);

        Running running = new Running(date, 25, 3);

        Cycling cycling = new Cycling(date, 30, 15);

        Swimming swimming = new Swimming(date, 30, 20);

        List<Activity> activities = new List<Activity>
        {
            running,
            cycling,
            swimming
        };

        Console.Clear();
        foreach (Activity a in activities)
        {
            Console.WriteLine($"- {a.GetSummary()}");
            Console.WriteLine();
        }
    }
}