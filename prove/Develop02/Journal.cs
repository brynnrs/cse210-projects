public class Journal
{
    public List<Entry> _entries;

    public void AddEntry()
    {
        DateTime theCurrentDT = DateTime.Now;
        string dateText = theCurrentDT.ToShortDateString();

        PromptGenerator aPrompt = new PromptGenerator();        
        string prompt = aPrompt.GetRandomPrompt();
        Console.WriteLine(prompt);

        Console.Write("> ");
        string entry = Console.ReadLine();

        Entry anEntry = new Entry();
        anEntry._date = dateText;
        anEntry._promptText = prompt;
        anEntry._entryText = entry;
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void LoadFromFile(string file)
    {

    }

    public void SaveToFile(string file)
    {

    }
}
