using System;

class Program
{
    static void Main(string[] args)
    {        
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);
        Console.WriteLine("Welcome to the number guessing game!\nTo play, please guess a number between 1 and 100.");

        int guessNumber = -1;

        do
        {
            Console.Write("What is your guess? ");
            string inputNumber = Console.ReadLine();
            guessNumber = int.Parse(inputNumber);

            if (guessNumber < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guessNumber > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
        while (guessNumber != magicNumber);
    }
} 