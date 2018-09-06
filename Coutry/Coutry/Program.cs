using Newtonsoft.Json;
using System;
using System.Net.Http;

namespace Coutry
{
    class Program
    {
        static void Main(string[] args)
        {
            Commad command = new Commad();
            var xs = command.GetAllInformationFromApi();

            command.PopulateCountries(xs);

            command.PupulateVAT(xs);

            command.ConnectTables(xs);


            //Commad myCommand = new Commad();
            //myCommand.GetAllInformationFromApi();
            //using (var webClient1 = new HttpClient())
            //{


            //    string content1 = webClient1.GetAsync("https://jsonvat.com/").Result.Content.ReadAsStringAsync().Result;
            //    //string con = @"Server= (localdb)\mssqllocaldb;Database=EuroTaxes";
            //   // var myList = new List<object>();

            //    var xs = JsonConvert.DeserializeObject<Rootobject>(content1);






            //    foreach (var item in xs.rates)
            //    {
            //        // Bygg ihop din SQL-sträng
            //        string sql = "insert into CountryCode(Name) values (' " + xs.rates[0].country_code + "')";

            //        // Anropa databasen 
            //    }


            //foreach (var item in xs.rates)
            //{

            //    foreach (var item1 in item.periods)
            //    {

            //        Console.WriteLine("".PadRight(30) + "Country Name".PadRight(30) + xs.rate.periods.rates.name);
            //        Console.WriteLine("".PadRight(30) + "Country Code".PadRight(30) + item.code);
            //        Console.WriteLine("".PadRight(30) + "Effective From".PadRight(30) + item1.effective_from);
            //        Console.WriteLine("".PadRight(30) + "Standard Tax".PadRight(30) + item1.rates.standard);
            //        Console.WriteLine("".PadRight(30) + "Reduced Tax".PadRight(30) + item1.rates.reduced);


            //        Console.WriteLine();
            //    }
            //}

        }



        }
    }

