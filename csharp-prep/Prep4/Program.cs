using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        //Create the list.
        List<int> numbers = new List<int>();
        
        //Display instructions to the user.
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        //Prompt user for numbers and add them to the list.
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

        //Find and display the sum.
        int sum = 0;
        foreach (int number in numbers)
        {
            sum = sum + number;
        }
        Console.WriteLine($"The sum is: {sum}");

        //Find and display the average.
        int amntOfNums = numbers.Count;
        float average = ((float)sum)/amntOfNums;
        Console.WriteLine($"The average is: {average}");

        //Find and display the largest number.
        int largest = numbers [0];
        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }
        Console.WriteLine($"The largest number is: {largest}");
    }
}