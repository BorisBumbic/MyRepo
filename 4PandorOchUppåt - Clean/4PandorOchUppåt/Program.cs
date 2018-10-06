using System;
using System.Collections.Generic;

namespace _4PandorOchUppåt
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberString = "123456";
            List<char> charList = StringManipulator.ReturnListOfCharacters(numberString);
            charList.ForEach(Console.WriteLine);
        }

    }
}
