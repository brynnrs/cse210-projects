using System;

class Program
{
    static void Main(string[] args)
    {
        //Call each function, save return values and pass data as necessary.

        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int sqNum = SquareNumber(userNumber);
        
        DisplayResult(userName, sqNum);

        //Sample Output:
        //
        //Please enter your name: Brother Burton
        //Please enter your favorite number: 42
        //Brother Burton, the square of your number is 1764


        //Displays the message, "Welcome to the Program!"
        static void DisplayWelcome ()
        {
            Console.WriteLine("Welcome to the program!");
        }
        
        //Asks for and returns the user's name (as a string)
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        //Asks for and returns the user's favorite number (as an integer)
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            
            return number;
        }

        //Accepts an integer as a parameter and returns that number squared (as an integer)
        static int SquareNumber(int number)
        {
            int square = number * number;

            return square;
        }
        
        // Accepts the user's name and the squared number and displays them.
        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}");
        }
    }
}