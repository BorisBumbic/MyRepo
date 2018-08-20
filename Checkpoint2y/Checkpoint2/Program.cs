using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkpoint2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkMagenta;

            var RumListan = new List<Room>();

            string userInput =   "vardagsrum 100m2 | hall 45m2 | toalet 444m2"; //Console.ReadLine();

            string[] userInputSplit = userInput.Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in userInputSplit)
            {
                var Rum = new Room();

                string[] secondSplit = item.Trim().Split(' ');

                string name = secondSplit[0];
                string sizeOfRoom = secondSplit[1].Replace("m2", "");

                Rum.name = name;
                Rum.kvadratMeter = int.Parse(sizeOfRoom);

                RumListan.Add(Rum);
            }

            var NyaRumListan = RumListan.OrderByDescending(x => x.kvadratMeter);

            foreach (var item in NyaRumListan)
            {
                Console.WriteLine($"{item.name}  {item.kvadratMeter}");
            }

            foreach (var item in NyaRumListan)
            {
                Console.WriteLine($"{item.name}");
                break;
            }
           
        }
    }
}
