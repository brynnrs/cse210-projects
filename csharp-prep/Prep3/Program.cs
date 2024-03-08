using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        string inputNumber = Console.ReadLine();
        int magicNumber = int.Parse(inputNumber);
        
        int guessNumber = -1;
        do
        {
            Console.Write("What is your guess? ");
            string inputNumber2 = Console.ReadLine();
            guessNumber = int.Parse(inputNumber2);

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