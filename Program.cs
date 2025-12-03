using System;
namespace Rectanglee
{
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


        // For task 2 Delegate
        Methods methods = new Methods();
        Console.WriteLine(".                       ");
        Console.WriteLine("=== Task2: Calculate Delegate ===");

        // Create delegate objects
        Calculate addDel = methods.Add;
        Calculate subDel = methods.Sub;

        // Call methods using delegates
        Console.WriteLine("Addition using delegate: " + addDel(10, 5));
        Console.WriteLine("Subtraction using delegate: " + subDel(10, 5));

        Console.WriteLine("\n=== Part 2: Discount Strategy Delegate ===");

        double price = 1000.0;
        // Create delegate objects for discount strategies
        DiscountStrategy festDel = methods.FestivalDiscount;
        DiscountStrategy seasDel = methods.SeasonalDiscount;
        DiscountStrategy noDiscDel = methods.NoDiscount;

        // Apply discounts using delegates
        Console.WriteLine("Original Price: " + price);
        Console.WriteLine("Festival Discount Price: " + festDel(price));
        Console.WriteLine("Seasonal Discount Price: " + seasDel(price));
        Console.WriteLine("No Discount Price: " + noDiscDel(price));
    }
}
}