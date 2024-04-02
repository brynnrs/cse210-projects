using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment simpleAssign = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(simpleAssign.GetSummary());

        MathAssignment mathAssign = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(mathAssign.GetSummary());
        Console.WriteLine(mathAssign.GetHomeworkList());

        WritingAssignment writingAssign = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writingAssign.GetSummary());
        Console.WriteLine(writingAssign.GetWritingInformation());        
    }
}