using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListMetoder
{
    class Class1
    {
        public static List<int> DoubleInput(List<int> numbers)
        {
            var returnList = new List<int>();

            foreach (var item in numbers)
            {
                int temp = item * 2;
                returnList.Add(temp);
            }
            return returnList;
        }


        public static List<int> Add100ToEachNumber(List<int> numbers)
        {
            var returnList = new List<int>();

            foreach (var item in numbers)
            {
                int temp = item + 100;
                returnList.Add(temp);
            }
            return returnList;
        }

        public static List<int> GetNumbersHigherThan1000(List<int> numbers)
        {
            var returnList = new List<int>();

            foreach (var item in numbers)
            {
                if (item > 1000)
                    returnList.Add(item);

            }

            return returnList;
        }

        public static List<int> GetNumbersDividableByFive(List<int> numbers)
        {
            var returnList = new List<int>();

            foreach (var item in numbers)
            {
                if (item % 5 == 0)
                    returnList.Add(item);
            }
            return returnList;
        }
        public static List<int> NegateEachNumber(List<int> numbers)
        {
            var returnList = new List<int>();

            foreach (var item in numbers)
            {
                int temp = item * -1;
                returnList.Add(temp);
            }
            return returnList;
        }
    }
}
