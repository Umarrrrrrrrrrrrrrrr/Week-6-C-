using System;
namespace Rectanglee
{
    
    // Delegate that accepts two integers and returns an integer
    public delegate int Calculate(int a, int b);

    // Delegate that accepts a price and returns discounted price
    public delegate double DiscountStrategy(double price);

    public class Methods
    {
        public int Add(int a, int b) => a + b;
        public int Sub(int a, int b) => a - b;

        // methods for festivediscount
        public double FestivalDiscount(double price) => price * 0.8; // 20% discount
        public double SeasonalDiscount(double price) => price * 0.9; // 10
        public double NoDiscount(double price) => price; // no discount

        // 2.1 Methods that accepts price + delegate
        public double CalculateFinalPrice(double originalPrice, DiscountStrategy strategy) => strategy(originalPrice);
    }
}
