using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Rockstars
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rockstarsArray = new string[] { "Jim Morrison", "Ozzy Osborne", "Mick Jagger", "DIO" };
            List<string> rockstarsList = new List<string> { "Jim Morrison", "Ozzy Osborne", "Mick Jagger", "DIO" };
            
            Rockstars.DisplayRockstars(rockstarsArray);
            Rockstars.DisplayRockstars(rockstarsList);
            Rockstars.DisplayRockstarsIE(rockstarsArray);
            Rockstars.DisplayRockstarsIE(rockstarsList);
        }
    }
}
