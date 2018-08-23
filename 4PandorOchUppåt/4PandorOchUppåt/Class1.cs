using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4PandorOchUppåt
{
    class Class1
    {
        public static List<char> ReturnListOfNumbers(string numbers)
        {
            var returnList = new List<char>();
            returnList = numbers.ToList();
            return returnList;
        }
    }

}
