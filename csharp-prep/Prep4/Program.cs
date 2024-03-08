using System;
using System.Diagnostics.CodeAnalysis; //.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        int inputNumber = -1;

        do
        {
            Console.Write("Enter number: ");
            inputNumber = int.Parse(Console.ReadLine());
            
            if (inputNumber != 0)
            {
                numbers.Add(inputNumber);
            }
            
        }
        while (inputNumber != 0);

        int sum = 0;
        foreach (int number in numbers)
        {
            sum = sum + number;
        }
    }
}