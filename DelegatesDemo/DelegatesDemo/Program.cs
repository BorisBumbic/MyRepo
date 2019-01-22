using System;
using System.IO;

namespace DelegatesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string dirPath = @"C:\Users\Administrator\Desktop";
            var fileFinder = new FileFinder();

            fileFinder.FindFiles(dirPath, MyTextFilter);
            Console.WriteLine();

            fileFinder.FindFiles(dirPath, p => Path.GetExtension(p) == ".txt");
            Console.WriteLine();
        }

        public static bool MyTextFilter(string path)
        {
            return Path.GetExtension(path) == ".txt";
        }
    }
}
