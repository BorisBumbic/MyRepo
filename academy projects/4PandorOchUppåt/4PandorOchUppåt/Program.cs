using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4PandorOchUppåt
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "123456";
            List<char> charList = Class1.ReturnListOfNumbers(input);

            foreach (var item in charList)
            {
                Console.WriteLine(item);
            }
        }

    }
}
