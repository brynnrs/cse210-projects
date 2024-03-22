using System.IO;
using System.Reflection.Metadata.Ecma335;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        DateTime theCurrentDT = DateTime.Now;
        string dateText = theCurrentDT.ToShortDateString();

        PromptGenerator Prompts = new PromptGenerator();
        // PromptGenerator object that has a list that is populated        
        string prompt = Prompts.GetRandomPrompt();
        Console.WriteLine(prompt);

        Console.Write("> ");
        string entry = Console.ReadLine();

        //Storing data in new entry
        newEntry._date = dateText;
        newEntry._promptText = prompt;
        newEntry._entryText = entry;

        //Add to entries list
        _entries.Add(newEntry);

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

        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            outputFile.WriteLine(entry);
        }
    }
} 
