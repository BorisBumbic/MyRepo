using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Böcker_1
{
    class Book
    {
        string authorName;
        string ISBN;
        int numberOfPages;
        
   

        public void SetAuthorName(string name)
        {
            authorName = name;
        }

        public string GetAuthorName()
        {
            return authorName;
        }

        public void SetISBN(string number)
        {
            if (Regex.IsMatch(number, @"\d\d\d-\d-\d\d-\d\d\d\d\d\d-\d$"))
            ISBN = number;
        }

        public string GetISBN()
        {
            return ISBN;
        }

        public void SetNumberOfPages(int pageNumbers)
        {
            numberOfPages = pageNumbers;

            if (numberOfPages > 1000)
                numberOfPages = 300;
        }

        public int GetNumberOfPages()
        {
            return numberOfPages;
        }

        public string BookThicknessCalculation()
        {
            if (numberOfPages < 100)
                return "Tunn";
            else if (numberOfPages > 100 && numberOfPages < 300)
                return "Normal";
            else
                return "Tjock";
        }

        public double WeightInGrams()
        {
            double bookWeight = numberOfPages * 0.8;
            return bookWeight;
        }

    }
}


