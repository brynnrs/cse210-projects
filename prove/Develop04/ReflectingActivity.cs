public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity() : base()
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        CreatePromptList();
        CreateQuestionList();
    }

    public void Run()
    {
        Console.WriteLine("\nConsider the following prompt:");
        DisplayPrompt();
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(_pause);
        Console.Clear();
        DisplayQuestions();
    }

    public void CreatePromptList()
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };       
    }
    
    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        string randomPrompt = _prompts[randomGenerator.Next(0,_prompts.Count)];
        _prompts.Remove(randomPrompt);
        return randomPrompt;
    }

    public void CreateQuestionList()
    {
        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }
    public string GetRandomQuestion()
    {
        Random randomGenerator = new Random();
        string randomQuestion = _questions[randomGenerator.Next(0,_questions.Count)];
        _questions.Remove(randomQuestion);
        return randomQuestion;
    }

    public void DisplayPrompt()
    {
        bool isDisplayed = false;
        while (!isDisplayed)
        {
            if (_prompts.Count > 0)
            {
                Console.WriteLine($"\n——— {GetRandomPrompt()}———");
                isDisplayed = true;  
            }
            else
            {
                CreatePromptList();
            }
        }
    }

    public void DisplayQuestions()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            if (_questions.Count > 0)
            {
            Console.Write($"> {GetRandomQuestion()} ");
            ShowSpinner(10);
            Console.WriteLine();
            }
            else
            {
                CreateQuestionList();
            }
        }
    }
}