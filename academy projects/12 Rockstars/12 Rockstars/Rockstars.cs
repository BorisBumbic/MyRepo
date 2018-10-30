using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Rockstars
{
    class Rockstars
    {
        public static void DisplayRockstars(string[] rockstars)
        {
            Console.WriteLine("StringArray:");
            foreach (var item in rockstars)
            {
                Console.WriteLine($"*   {item}");
            }
        }

        public static void DisplayRockstars(List<string> rockstars)
        {
            Console.WriteLine("StringLista:");
            foreach (var item in rockstars)
            {
                Console.WriteLine($"*   {item}");
            }
        }

        public static void DisplayRockstarsIE(IEnumerable<string> rockstars)
        {
            Console.WriteLine("IEnumerable:");
            foreach (var item in rockstars)
            {
                Console.WriteLine($"*   {item}");
            }

        }
        public static void RemoveRockstars(IEnumerable<string> rockstars, int nummer)
        {
            nummer--;
        }
    }
}
