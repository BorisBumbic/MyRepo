using Newtonsoft.Json;
using Onlinestore.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Onlinestore.Viewservice
{
    public class SmhiServices
    {
        public Rootobject GetMeteorologicalForecast(decimal longitude, decimal latitude)
        {
            string sLongitude = Math.Round(longitude, 3).ToString(new CultureInfo("en"));
            string sLatitude = Math.Round(latitude, 3).ToString(new CultureInfo("en"));

            string url = $"https://opendata-download-metfcst.smhi.se/api/category/pmp3g/version/2/geotype/point/lon/{sLongitude}/lat/{sLatitude}/data.json";


            using (HttpClient client = new HttpClient())
            using (HttpResponseMessage response = client.GetAsync(url).Result)
            using (HttpContent content = response.Content)
            {
                if (!response.IsSuccessStatusCode)
                    throw new Exception(response.ReasonPhrase);
                string result = content.ReadAsStringAsync().Result;
                //return result;
                return JsonConvert.DeserializeObject<Rootobject>(result);


            }


        }


        public List<TimeTemp> FilterTemperature(Rootobject result, DateTime date)
        {
            return result.timeSeries.Where(x => x.validTime.Day == date.Day).Select(x => new TimeTemp
            {
                Temp = x.parameters.Single(y => y.name == "t").values.First(),
                Time = x.validTime

            }).ToList();
        }
    }
}
