public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {
        _name = "Activity";
        _description = "This is a basic Activity";
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.\n");
        Console.WriteLine($"{_description}\n");
        Console.WriteLine("How long, in seconds, would you like for your session?");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready...");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!!");
        ShowSpinner(7);
        Console.WriteLine($"\nYou have completed another {_duration} of the {_name}");
        ShowSpinner(7);
    }

    public void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("—");
        animationStrings.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            foreach (string s in animationStrings)
            {
                Console.Write(s);
                Thread.Sleep(500);
                Console.Write("\b \b");
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
    }
}