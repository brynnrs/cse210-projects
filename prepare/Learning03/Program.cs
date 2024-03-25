using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(6);
        Fraction f3 = new Fraction(6,7);
        Console.WriteLine("Hello Learning03 World!");

        Fraction f4 = new Fraction(8,9);
        Console.WriteLine(f4.GetTop());
        Console.WriteLine(f4.GetBottom());
        f4.SetTop(5);
        f4.SetBottom(6);
        Console.WriteLine(f4.GetTop());
        Console.WriteLine(f4.GetBottom());

    }
}