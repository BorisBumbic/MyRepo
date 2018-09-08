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
            var xs = command.GetUnprocessedInformationFromApi();

            //command.PopulateCountries(xs);

            //command.PupulateVAT(xs);

            //command.ConnectTables(xs);

            var list = command.ListStandardVAT();

            foreach (var item in list)
            {
                Console.WriteLine(item.countryName + "  " + item.standardVat);
            }

        }
    }
}
