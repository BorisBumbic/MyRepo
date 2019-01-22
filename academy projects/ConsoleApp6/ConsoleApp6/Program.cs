using System;
using System.Net.Http.Headers;
using System.Text;
using System.Net.Http;
using System.Web;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ConsoleApp6
{
    public class Hej
    {
        public static void RequestSentiment()
        {
            var client = new HttpClient();
            //var queryString = HttpUtility.ParseQueryString("");

            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", "6712d8ff97cc46df9fff72c086d93709");

            var uri = "https://northeurope.api.cognitive.microsoft.com/text/analytics/v2.0/sentiment?" /*+ queryString*/;

            var r = new RootObject
            {
                documents = new List<Document>
            {
               new Document
               {
                   text="Why is this so shit?",
                   language="en",
                   id="1"
               },
                new Document
               {
                   text="Trump bla bla",
                   language="en",
                   id="2"
               },

            }
            };

            string inp = JsonConvert.SerializeObject(r);

            byte[] byteData = Encoding.UTF8.GetBytes(inp);

            using (var content = new ByteArrayContent(byteData))
            {
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                 var response = client.PostAsync(uri, content);

                var result = response.ReadAsStringAsync();
                Console.WriteLine(result);
            }

        }



        private static void Main(string[] args)
        {
            RequestSentiment();
        }

    }
}