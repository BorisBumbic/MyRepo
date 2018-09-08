using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gnomecheckpoint
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataAccess = new DataAccess();
            List<Gnome> gnomes = dataAccess.GetGnomesFromDatabase();
            DisplayGnomes(gnomes);
        }

        public static void DisplayGnomes(List<Gnome> GnomeList)
        {
            string name = "NAMN";
            string beard = "HAR SKÄGG";
            string alignment = "ÄR OND";
            string temperament = "TEMPERAMENT";
            string race = "RAS";
            Console.WriteLine($"|{name.PadRight(15)}|{beard.PadRight(15)}|{alignment.PadRight(15)}|{temperament.PadRight(15)}|{race.PadRight(15)}|");

            foreach(var item in GnomeList)
            {
                Console.WriteLine($"|{item.name.PadRight(15)}|{item.beard.PadRight(15)}|{item.alignment.PadRight(15)}|{item.temperament.ToString().PadRight(15)}|{item.race.PadRight(15)}|");
            }
        }
    }
}
