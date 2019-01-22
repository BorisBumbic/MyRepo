using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListMetoder
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int> { 1001, 2, 3, 4000, 5 };

            var newList = Class1.NegateEachNumber(intList);

            foreach (var item in newList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
