using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Böcker_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product.Book book1 = new Product.Book();
            Product.EBook ebook1 = new Product.EBook();

            Console.WriteLine("Skriv in författarens namn.");
            book1.SetAuthorName(Console.ReadLine());
            Console.WriteLine("Skriv in bokens ISBN nummer. Formatet är 000-0-00-000000-0");
            book1.SetISBN(Console.ReadLine());
            Console.WriteLine("Skriv in hur många sidor boken har.");
            book1.SetNumberOfPages(int.Parse(Console.ReadLine()));

            Console.WriteLine($"Info om boken:");
            Console.WriteLine();
            Console.WriteLine($"   ISBN:        {book1.GetISBN()}");
            Console.WriteLine($"   Författare:  {book1.GetAuthorName()}");
            Console.WriteLine($"   Antal sidor: {book1.GetNumberOfPages()}");
            Console.WriteLine($"   Vikt:        {book1.WeightInGrams()} gram");
            Console.WriteLine($"   Storlek:     {book1.BookThicknessCalculation()}");
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Olika test");
            Console.WriteLine($"Är book1 en bok?  {book1 is Product.Book}");
            Console.WriteLine($"Är book1 en ebok?  {book1 is Product.EBook}");
            Console.WriteLine($"Är book1 en produkt?  {book1 is Product}");
            Console.WriteLine();
            Console.WriteLine($"Är ebook1 en bok?  {ebook1 is Product.Book}");
            Console.WriteLine($"Är ebook1 en ebok? = {ebook1 is Product.EBook}");
            Console.WriteLine($"Är ebook1 en produkt? = {ebook1 is Product}");

            ebook1.SendTo("happy@feet.com");
        }
    }
}
