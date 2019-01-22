using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Timers;


namespace SlConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Metro_Load();
            Console.ReadKey();
        }
        static void Metro_Load()
        {
            System.Timers.Timer timer = new System.Timers.Timer();
            Console.Clear();
            timer.Enabled = true;
            timer.Elapsed += timer_Tick;
            timer.Interval = 5000;
            timer.AutoReset = true;
            getSLdata();

        }

        static void timer_Tick(Object source, ElapsedEventArgs e)
        {
            getSLdata();   
        }

        static void getSLdata()
        {
            using (var webClient = new HttpClient())
            {
                Console.SetCursorPosition(0, 0);
                

                string content = webClient.GetAsync("http://api.sl.se/api2/realtimedeparturesV4.json?key=fa7f8eaa090b4d6791ae9eda0f4384db&siteid=9302&timewindow=0").Result.Content.ReadAsStringAsync().Result;

                var x = JsonConvert.DeserializeObject<RootObject>(content);

                //För att kunna skilja på tåg som åker mot- och bort från T-centralen gör vi nedan två listor.
                var periferi = new List<Metro>();
                var central = new List<Metro>();

                //I denna foreach-loop så går vi igenom all data vi hämtat ifrån Trafiklab och delar upp den så att rätt avgångar hamnar i rätt lista.
                //Kriteriet för vår uppdelning är ifall avgångens destination är Akalla eller inte.
                foreach (var metro in x.ResponseData.Metros)
                {
                    if (metro.Destination != "Akalla")
                        central.Add(metro);
                    else
                        periferi.Add(metro);

                }

                //För att for-loopen nedan inte ska generera ett "OutOfRangeException" så skapar vi två ints. De kommer att jämföras i for-loopen och den
                //med lägre värde kommer att användas som antalet gånger loopen skall köras.
                int len1 = central.Count;
                int len2 = periferi.Count;

                //Nedan deklarerar vi variabeln 'time' som är av typen DateTime. I den sparar vi den exakt tidpunkten informationen mottogs ifrån Trafiklab.
                DateTime time = x.ResponseData.LatestUpdate;

                //I  utskriftsdelen av vår kod så är den intressantaste delen användandet av 'positioneringsvariabler'. Exempel: {central[i].Destination, -5}. 
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine($"--Kista Tunnelbanestation--{time}--");


                Console.WriteLine("------------------------------------------------\n************************************************\n** Mot T-Centralen *********** Mot Akalla ******\n************************************************");


                for (int i = 0; i < Math.Min(len1, len2); i++)
                {
                    Console.WriteLine(String.Format($"** {central[i].Destination.PadRight(5)} {central[i].DisplayTime.PadRight(6)} *** {periferi[i].Destination.PadRight(5)} {periferi[i].DisplayTime.PadRight(8)} **"));
                }
                Console.WriteLine("************************************************\n************************************************");
            };
        }
    }
}

