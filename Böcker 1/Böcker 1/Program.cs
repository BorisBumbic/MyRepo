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
            Book book = new Book();
            Console.WriteLine("Skriv in författarens namn.");
            book.SetAuthorName(Console.ReadLine());
            Console.WriteLine("Skriv in bokens ISBN nummer. Formatet är 000-0-00-000000-0");
            book.SetISBN(Console.ReadLine());
            Console.WriteLine("Skriv in hur många sidor boken har.");
            book.SetNumberOfPages(int.Parse(Console.ReadLine()));

            Console.WriteLine($"Info om boken:");
            Console.WriteLine();
            Console.WriteLine($"   ISBN:        {book.GetISBN()}");
            Console.WriteLine($"   Författare:  {book.GetAuthorName()}");
            Console.WriteLine($"   Antal sidor: {book.GetNumberOfPages()}");
            Console.WriteLine($"   Vikt:        {book.WeightInGrams()} gram");
            Console.WriteLine($"   Storlek:     {book.BookThicknessCalculation()}");
            Console.WriteLine();

        }
    }
}
