public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        CreatePromptList();
    }

    public void Run()
    {
        Console.WriteLine("List as many responses as you can to the following prompt:");
        GetRandomPrompt();
        Console.Write("You may begin in: ");
        ShowCountDown(_pause);
        Console.WriteLine();
        GetListFromUser();
        Console.WriteLine($"You listed {_count} items!");
    }

    public void CreatePromptList()
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };       
    }
    
    public void GetRandomPrompt()
    {
        bool isDisplayed = false;
        while (!isDisplayed)
        {
            if (_prompts.Count > 0)
            {
                Random randomGenerator = new Random();
                string randomPrompt = _prompts[randomGenerator.Next(0,_prompts.Count)];
                _prompts.Remove(randomPrompt);
                Console.WriteLine($"\n——— {randomPrompt}———");
                isDisplayed = true;
            }
            else
            {
                CreatePromptList();
            }
        }
    }

    public List<string> GetListFromUser()
    {
        List<string> userList = new List<string>();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write($"> ");
            string listItem = Console.ReadLine();
            userList.Add(listItem);
        }
        _count = userList.Count;
        return userList;
    }
}