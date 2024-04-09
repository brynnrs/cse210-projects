using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        
        Square shape1 = new Square("purple", 6);
        shapes.Add(shape1);

        Rectangle shape2 = new Rectangle("green", 2, 3);
        shapes.Add(shape2);

        Circle shape3 = new Circle("blue", 4);
        shapes.Add(shape3);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();
            
            Console.WriteLine($"Color: {color} \n Area: {area}");
        }
    }
}