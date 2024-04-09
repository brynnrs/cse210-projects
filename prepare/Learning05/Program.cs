using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("purple", 6);
        Console.WriteLine(square.GetColor());
        Console.WriteLine(square.GetArea());
    }
}