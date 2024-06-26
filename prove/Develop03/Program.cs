using System;

// Showing Creativity and Exceeding Requirements:
// I added the functionality for HideRandomWords to randomly select from only those words that were not already hidden.
class Program
{
    static void Main(string[] args)
    {
        bool isRunning = true;
        
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.");
        
        while (isRunning)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
            string userInput = Console.ReadLine();

            if (userInput == "quit" || scripture.IsCompletelyHidden())
            {
                return;
            }
            scripture.HideRandomWords(3);
        }
        
    }
}