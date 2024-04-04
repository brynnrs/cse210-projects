public class BreathingActivity : Activity
{
    public BreathingActivity() : base()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void Run()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine($"Breathe in...");
            ShowCountDown(_pause);
            Console.WriteLine($"Breathe out...");
            ShowCountDown(_pause);
        }
    }
}