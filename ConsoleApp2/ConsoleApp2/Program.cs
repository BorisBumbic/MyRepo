using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal chocolateBar = 24;

            Console.WriteLine("Hur många är ni som ska dela på kakan?");
            while (true)
            {
                try
                {
                    decimal antalPers = int.Parse(Console.ReadLine());

                    decimal perSkalle = chocolateBar / antalPers;

                    Console.WriteLine($"Ni är {antalPers} som delar på {chocolateBar} bitar. Alltså får alla {perSkalle} var.");

                    break;
                }
                catch (DivideByZeroException ex)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("Något gick fel. ");
                    Console.WriteLine(ex.Message);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                catch (FormatException exc)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("Något gick fel. ");
                    Console.WriteLine(exc.Message);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                catch (DevilException)
                {
                    Console.WriteLine("Djävulens nummer!");
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Något gick jäääävligt fel.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
    }
}
