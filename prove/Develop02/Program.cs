using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        
        Journal theJournal = new Journal();
        Entry anEntry = new Entry();

        int response = 0;

        while (response != 5)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            response = int.Parse(Console.ReadLine());

            if (response == 1)
            {
                theJournal.AddEntry(anEntry);
                response = 0;
            }

            else if (response == 2)
            {
                theJournal.DisplayAll();
                response = 0;
            }

            else if (response == 3)
            {
                Console.WriteLine("What is the filename?");
                string filename = Console.ReadLine();
                theJournal.LoadFromFile(filename);
                response = 0;
            }

            else if (response == 4)
            {
                Console.WriteLine("What is the filename?");
                string filename = Console.ReadLine();
                theJournal.SaveToFile(filename);
                response = 0;
            }
        }

    }
} 