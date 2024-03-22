public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    

    public string GetRandomPrompt()
    {
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");
        _prompts.Add("What did I do right today?");
        _prompts.Add("What was something I thought about today? And why did I think about it?");
        _prompts.Add("What goals am I working towards right now?");
       
        Random randomGenerator = new Random();
        string randomPrompt = _prompts[randomGenerator.Next(0,_prompts.Count)];

        return randomPrompt;
    }
} 