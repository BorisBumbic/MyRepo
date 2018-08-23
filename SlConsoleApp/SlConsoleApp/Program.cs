using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SlConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var webClient = new WebClient()) 
            {
               byte[] data = webClient.DownloadData("http://api.sl.se/api2/realtimedeparturesV4.json?key=fa7f8eaa090b4d6791ae9eda0f4384db&siteid=9192&timewindow=0");

                JsonConvert.DeserializeObject<MetroCollection>

            }
        }
    }
}
