using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SlConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var webClient = new HttpClient()) 
            {
                //byte[] data = webClient.DownloadData("http://api.sl.se/api2/realtimedeparturesV4.json?key=fa7f8eaa090b4d6791ae9eda0f4384db&siteid=9192&timewindow=0");


                string content = webClient.GetAsync("http://api.sl.se/api2/realtimedeparturesV4.json?key=fa7f8eaa090b4d6791ae9eda0f4384db&siteid=9302&timewindow=0").Result.Content.ReadAsStringAsync().Result;

                var x = JsonConvert.DeserializeObject<RootObject>(content) ;

                var periferi = new List<Metro>();
                var central = new List<Metro>();

                foreach (var metro in x.ResponseData.Metros)
                {
                    if (metro.Destination != "Akalla") 
                            central.Add(metro);
                    else
                        periferi.Add(metro); 

                }

                int len1 = central.Count;
                int len2 = periferi.Count;
                int little = len1;
                if (little < len2)
                    little = len2;

                DateTime time = x.ResponseData.LatestUpdate;
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine($"--Kista Tunnelbanestation--{time}--");


                Console.WriteLine("------------------------------------------------\n************************************************\n***Mot T-Centralen*************Mot Akalla*******\n************************************************");


                for (int i = 0; i < len2; i++)
                {
                    Console.WriteLine($"**{central[i].Destination}  {central[i].DisplayTime} *** {periferi[i].Destination}  {periferi[i].DisplayTime}");

                }
                Console.WriteLine("************************************************\n************************************************");
            }
        }
        //private void Metro_Load(object x, EventArgs e)
        //{
        //    Timer timer = new Timer();
        //    timer.Interval = (60 * 1000);
        //    timer.Tick += new EventHandler(timer_Tick);
        //    timer.Start();
        //}

        //private void timer_Tick(object sender, EventArgs e)
        //{
        //    RefreshControls();
        //}
    }
}

/*
 {
 
    "ResponseData": {
        "LatestUpdate": "2018-08-23T13:58:45",

        "Metros": [
            {
                "GroupOfLine": "tunnelbanans gröna linje",
                "DisplayTime": "Nu",
                "TransportMode": "METRO",
                "LineNumber": "18",
                "Destination": "Alvik",
                "JourneyDirection": 1,
                "StopAreaName": "Slussen",
                "StopAreaNumber": 1011,
                "StopPointNumber": 1011,
                "StopPointDesignation": "1",
                "TimeTabledDateTime": "2018-08-23T13:59:00",
                "ExpectedDateTime": "2018-08-23T13:59:28",
                "JourneyNumber": 10319,
                "Deviations": null
            },
            ]
            }
            }
     
     */
