using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment mathAssign = new MathAssignment("Roberto Rodriguez", "Fractions","7.3","8-19");
        Console.WriteLine(mathAssign.GetSummary());
        Console.WriteLine(mathAssign.GetHomeworkList());        
    }
}