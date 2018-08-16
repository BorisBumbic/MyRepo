using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlong_Tv_tablå
{
    class Show
    {
        public string Channel { get; set; }
        public TimeSpan StartAt { get; set; }
        public string Title { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var allLines = File.ReadAllLines("TextFile1.txt");

            var allShows = new List<Show>();

            foreach (var line in allLines)
            {
                string[] splittedLine = line.Split('*');
                var channel = splittedLine[0];
                var time = splittedLine[1];
                var title = splittedLine[2];

                var show = new Show();

                show.Title = title;
                show.Channel = channel;
                show.StartAt = TimeSpan.Parse(time);

                allShows.Add(show);
            }
            foreach (var show in allShows)
            {
                Console.WriteLine(show.Title);
            }

            Header("alla kanaler");

            foreach (var show in allShows)
            {
                Console.WriteLine(show.Channel +"\n");
            }

            var laterThan21 = new List<Show>();

            Header("Program som börjar senare än 21");

            foreach (var show in allShows)
            {
                if (show.StartAt.Hours >= 21)
                {
                    laterThan21.Add(show);
                }
            }

            foreach (var item in laterThan21)
            {
                WriteInfoAboutShow(item);

            }


            //Kolla noga på den nedstående .Where metoden. Den högra sidan av den är en condition.
            var random = allShows.Where(x => x.StartAt.Hours >= 21);

            foreach (var item in random)
            {
                Console.WriteLine($"{item.Channel.PadRight(4)} {item.StartAt} {item.Title}");
            }

            var showList = allShows.Where(x => x.Channel == "SVT1").OrderBy(x => x.StartAt);

            Header("program på svt1 i kronologisk ordning.");

            foreach (var item in showList)
            {
                WriteInfoAboutShow(item);
            }

            WriteInfoAboutShows(allShows);
        }

        private static void Header(string v)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"\n ________{v.ToUpper()}________ \n");
            Console.ResetColor();
        }

        private static void WriteInfoAboutShow(Show show)
        {
            Console.WriteLine($"{show.Channel.PadRight(4)}  {show.Title}  {show.StartAt}");
        }

        private static void WriteInfoAboutShows(List<Show> shows)
        {
            foreach (var item in shows)
            {
                Console.WriteLine($"{item.Channel.PadRight(4)}  {item.Title}  {item.StartAt}");
            }
            
        }
    }
}
