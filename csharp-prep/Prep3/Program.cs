using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        string inputNumber = Console.ReadLine();
        int magicNumber = int.Parse(inputNumber);

        Console.Write("What is your guess? ");
        string inputNumber2 = Console.ReadLine();
        int guessNumber = int.Parse(inputNumber2);

        if (guessNumber < magicNumber)
        {
            Console.Write("Higher");
        }
        else if (guessNumber > magicNumber)
        {
            Console.Write("Lower");
        }
        else
        {
            Console.Write("You guessed it!");
        }
    }
} 