using System;

class Program
{
    static void Main(string[] args)
    {
        DateTime date = DateTime.Now;

        Running running = new Running(date, 30, 3);

        Cycling cycling = new Cycling(date, 35, 12.5);

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
            Console.WriteLine($"> {a.GetSummary()}");
            Console.WriteLine();
        }
    }
}