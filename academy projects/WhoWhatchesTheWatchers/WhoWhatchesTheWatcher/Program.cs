using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WhoWhatchesTheWatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var x = new FileSystemWatcher();

                x.Path = @"C:\Users\Administrator\Desktop\testy";

                x.EnableRaisingEvents = true;

                x.Created += EnFilHarLagtsTill;

                x.Changed += XChanged;

                Console.ReadKey();

            }
        }
        private static void XChanged(object sender, FileSystemEventArgs e)
        {
            string linesy = "Filen " + e.FullPath + " har ändrats!";
            Console.WriteLine(linesy);
            File.AppendAllText(@"C:\Users\Administrator\Desktop\testy\maj.txt", linesy);
        }

        private static void EnFilHarLagtsTill(object sender, FileSystemEventArgs x)
        {
            string lines = "Filen " + x.FullPath + " har skapats!";
            Console.WriteLine(lines);
            File.AppendAllText(@"C:\Users\Administrator\Desktop\testy\maj.txt", lines);
        }
    }
}




