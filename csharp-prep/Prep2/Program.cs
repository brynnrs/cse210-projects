using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int gradePercentage = int.Parse(answer);

        if (gradePercentage >= 90)
        {
            Console.WriteLine("Letter Grade: A");
        }
        else if (gradePercentage >= 80)
        {
            Console.WriteLine("Letter Grade: B");
        }
        else if (gradePercentage >= 70)
        {
            Console.WriteLine("Letter Grade: C");
        }
        else if (gradePercentage >= 60)
        {
            Console.WriteLine("Letter Grade: D");
        }
        else
        {
            Console.WriteLine("Letter Grade: F");
        }
    }
}