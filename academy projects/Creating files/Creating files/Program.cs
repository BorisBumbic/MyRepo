using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creating_files
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in vad du vill att din fil ska heta och adressen du vill att den ska ligga i.");

            string input = Console.ReadLine();
            while(true)

            try
            {
                File.CreateText($"{input}.txt");
                    
                Console.WriteLine($"Your file {input}.txt have been created.");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Obehöriga äga ej tillträda.");
                    break;
            }
            catch (ArgumentException)
            {
                    Console.WriteLine("Argumentet förstås ej.");
            }
            catch (Exception)
            {
                    Console.WriteLine("Något gick fel.");
            }
        }
    }
}
