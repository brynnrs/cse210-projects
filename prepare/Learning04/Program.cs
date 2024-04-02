using System;

class Program
{
    static void Main(string[] args)
    {
        WritingAssignment writingAssign = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writingAssign.GetSummary());
        Console.WriteLine(writingAssign.GetWritingInformation());        
    }
}