using System;

class Program
{
    static void Main(string[] args)
    {
        int response = 0;

        while (response !=4)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("Select a choice from the menu:");
            response = int.Parse(Console.ReadLine());

            if (response == 1)
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.DisplayStartingMessage();
                breathingActivity.Run();
                breathingActivity.DisplayEndingMessage();
                response = 0;
            }

            else if (response == 2)
            {
                response = 0;
            }

            else if (response == 3)
            {
                response = 0;
            }

            else
            {
                Console.WriteLine("Please choose a number corresponding to the menu (1-4)");
            }
        }
    }
}