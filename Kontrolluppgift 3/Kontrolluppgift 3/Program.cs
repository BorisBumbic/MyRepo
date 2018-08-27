using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontrolluppgift_3
{
    class Program
    {
        public static List<int> MultipleBy100AndAdd3(List<int> numbers)
        {
            var returnList = new List<int>();

            foreach (var item in numbers)
            {
                int temp = item * 100 + 3;
                returnList.Add(temp);
            }
            return returnList;
        }

        public static List<string> ReorderList(List<string> input, List<int> numbers)
        {
            var returnList = new List<string>();

            foreach (var item in numbers)
            {
                string temp = input[item-1];
                returnList.Add(temp);
            }
            return returnList;
        }

        static void Main(string[] args)
        {
            var testList = new List<int> { 1, 2, 4, 3 };
            var stringList = new List<string> { "a", "b", "c", "d" };

            //var outList = MultipleBy100AndAdd3(testList);

            var outList = ReorderList(stringList,testList);

            foreach (var item in outList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
