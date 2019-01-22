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
            Book book1 = new Book("000-0-00-000000-0", "A book about a boy");
            EBook ebook1 = new EBook("111-1-11-111111-1","A book about a girl");

            Console.WriteLine("Skriv in författarens namn.");
            book1.AuthorName = Console.ReadLine();
            Console.WriteLine("Skriv in bokens ISBN nummer. Formatet är 000-0-00-000000-0");
            book1.ISBN = Console.ReadLine();
            Console.WriteLine("Skriv in hur många sidor boken har.");
            book1.NumberOfPages = int.Parse(Console.ReadLine());

            Console.WriteLine($"Info om boken:");
            Console.WriteLine();
            Console.WriteLine($"   ISBN:        {book1.ISBN}");
            Console.WriteLine($"   Författare:  {book1.AuthorName}");
            Console.WriteLine($"   Antal sidor: {book1.NumberOfPages}");
            Console.WriteLine($"   Vikt:        {book1.WeightInGrams()} gram");
            Console.WriteLine($"   Storlek:     {book1.BookThicknessCalculation()}");
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Olika test");
            Console.WriteLine($"Är book1 en bok?  {book1 is Book}");
            Console.WriteLine($"Är book1 en ebok?  {book1 is EBook}");
            Console.WriteLine($"Är book1 en produkt?  {book1 is Product}");
            Console.WriteLine();
            Console.WriteLine($"Är ebook1 en bok?  {ebook1 is Book}");
            Console.WriteLine($"Är ebook1 en ebok? = {ebook1 is EBook}");
            Console.WriteLine($"Är ebook1 en produkt? = {ebook1 is Product}");

            ebook1.SendTo("happy@feet.com");
        }
    }
}
