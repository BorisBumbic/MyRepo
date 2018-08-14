using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modullering_hiss
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in hissens namn, startvåning, högsta våning, lägsta våning, samt steg tills service");
            var Bosse = new Elevator(Console.ReadLine(), int.Parse(Console.ReadLine()),
                int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));

            Console.WriteLine("     " + Bosse.Report());
            string inp1 = "Signal att åka upp en våning";
            Random.Info(inp1);
            Bosse.GoUp();
            Console.WriteLine($"       {Bosse.Report()}");

            Random.Info("Signal att åka upp en våning");
            Bosse.GoUp();
            Console.WriteLine("     " + Bosse.Report());

            Random.Info("Signal att åka upp en våning");
            Bosse.GoUp();
            Console.WriteLine("     " + Bosse.Report());

        }
    }
}
