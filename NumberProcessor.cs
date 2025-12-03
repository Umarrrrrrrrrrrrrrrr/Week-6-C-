using System;
using System.Collections.Generic;
using System.Linq;

namespace Rectanglee
{
    public class NumberProcessor
    {
        public void SquareNumbers()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            var squared = numbers.Select(n => n * n);

            Console.WriteLine("Squared Numbers:");
            foreach (var n in squared)
                Console.WriteLine(n);
        }
    }
}
