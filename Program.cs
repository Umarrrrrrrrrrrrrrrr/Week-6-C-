using System;
namespace Rectanglee;

public class Program
{
    public static void Main(String[] args)
    {
        // For task 1 Rectangle
        Rectangle rect = new Rectangle();
        rect.Length = 10;
        rect.Breadth = 5;

        Console.WriteLine("rect.GetArea(): " + rect.GetArea());
        
        Console.WriteLine("rect.GetPerimeter(): " + rect.GetPerimeter());
        Console.WriteLine(rect.ShowDetails());
    }
}