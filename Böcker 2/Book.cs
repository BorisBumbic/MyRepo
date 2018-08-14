using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Böcker_1
{
    public class Product
    {

        private int myVar;

        Regex check = new Regex

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }

        string bookName;
        string authorName;
        string isbn;
        public int numberOfPages;
        
        public Product(string ISBNN, string name)
        {
            isbn = ISBNN;
            bookName = name;
        }

        public string AuthorName { get; set; }

        public string ISBN { get; set; }

        public int NumberOfPages { get; set; }

        public string BookThicknessCalculation()
        {
            if (NumberOfPages < 100)
                return "Tunn";
            else if (NumberOfPages > 100 && NumberOfPages < 300)
                return "Normal";
            else
                return "Tjock";
        }
        
        public int BookId { get; set; }
    }

    public class EBook : Product
    {
        public EBook(string s, string r) : base(s, r)
        {

        }
        public void SendTo(string value)
        {
            Console.WriteLine($"Boken till e-mailadressen {value}");
        }
    }
    public class Book : Product
    {
        public Book(string s, string r) : base(s, r)
        {
            Console.WriteLine();
        }
        public double WeightInGrams()
        {
            double bookWeight = NumberOfPages * 0.8;
            return bookWeight;
        }

    }


}


