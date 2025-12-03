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
        // Console.WriteLine("Original Price: " + price);
        // Console.WriteLine("Festival Discount Price: " + festDel(price));
        // Console.WriteLine("Seasonal Discount Price: " + seasDel(price));
        // Console.WriteLine("No Discount Price: " + noDiscDel(price));

        Console.WriteLine("\n=== Part 2.1: Calculate Final Price using Delegate ===");
        // 2.2 Calculate final prices using the method that accepts delegate
        Console.WriteLine("Festival Discount: " + methods.CalculateFinalPrice(price, festDel));
        Console.WriteLine("Seasonal Discount: " + methods.CalculateFinalPrice(price, seasDel));
        Console.WriteLine("No Discount: " + methods.CalculateFinalPrice(price, noDiscDel));


        Console.WriteLine("\n=== Part 2.3: Using Lambda Expressions for 30% Discount Strategy ===");

        // 2.3 Using lambda expressions -> 30% discount
        DiscountStrategy lamda30 = p => p * 0.7; 

        Console.WriteLine("30% Lamda Discount: " + methods.CalculateFinalPrice(price, lamda30));


        // Task 3: Using Func Delegate with Method
        Method m = new Method();
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        Console.WriteLine("\n=== Task 3: Using Func Delegate with Method ===");
        Console.WriteLine("Even numbers: ");
        m.ProcessNumbers(numbers, n => n % 2 == 0); 

        Console.WriteLine("Numbers greater than 10: ");
        m.ProcessNumbers(numbers, n => n > 10);



        // Task 4: Using LINQ to process collections
        Console.WriteLine("---------------------Task 4 Things----------------");
        NumberProcessor np = new NumberProcessor();
            BookStore bs = new BookStore();
            StudentService ss = new StudentService();

            np.SquareNumbers();
            bs.FilterPremiumBooks();
            ss.SortStudents();

    }
}
}