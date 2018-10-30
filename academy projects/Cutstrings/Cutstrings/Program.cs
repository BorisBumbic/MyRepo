using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cutstrings
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public string CutString(string input, int number)
        {
            var charList = input.ToList();
            string newString = "";

            for (int i = 0; i < number; i++)
            {
                newString += charList[i];
            }

            return newString;
        }
    }
}
