using System;

namespace Rectanglee
{
    public class Method
    {
        // Method that accepts numbers + Func condition
        public void ProcessNumbers(int[] numbers, Func<int, bool> condition)
        {
            foreach (int num in numbers)
            {
                if (condition(num))
                {
                    Console.WriteLine(num + " meets the condition.");
                }
            }
        }
    }
}