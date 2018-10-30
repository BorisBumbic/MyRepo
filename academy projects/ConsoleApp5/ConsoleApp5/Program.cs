using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {

            string path1 = "file1.txt";
            //string path2 = "file2.txt";

            string a = File.ReadAllText($"C:/SOurceTreeTMP/ConsoleApp5/ConsoleApp5/{path1}", Encoding.UTF8); //. ToString();

            List<string> b = a.Split(';').ToList();


            b.ForEach(Console.WriteLine);

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
