using System;
using System.Collections.Generic;
using System.Linq;

namespace Rectanglee
{
    public class BookStore
    {
        public void FilterPremiumBooks()
        {
            List<Book> books = new List<Book>
            {
                new Book("AI Fundamentals", 800),
                new Book("Machine Learning", 1500),
                new Book("Data Structures", 1200),
                new Book("Python Basics", 500)
            };

            var premiumBooks = books.Where(b => b.Price > 1000);

            Console.WriteLine("\nBooks above Rs. 1000:");
            foreach (var b in premiumBooks)
                Console.WriteLine($"{b.Title} - Rs. {b.Price}");
        }
    }
}
