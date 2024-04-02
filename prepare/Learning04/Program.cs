using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment simpleAssign = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(simpleAssign.GetSummary());
    }
}