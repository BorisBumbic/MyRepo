using System;
using System.Net.Http;
using Tolly.Domain.Models;
using Tolly.Domain.Services;

namespace Tolly.Infrastructure
{
    public class WebVechicleReader : IVechicleReader
    {
        public VechicleInfo Read(string item)
        {
            const string url = "http://happybits-001-site6.ftempurl.com/tolly";

            using (HttpClient client = new HttpClient())
            using (HttpResponseMessage response = client.GetAsync(url).Result)
            using (HttpContent content = response.Content)
            {
                if (!response.IsSuccessStatusCode)
                    throw new Exception(response.ReasonPhrase);

                string data = content.ReadAsStringAsync().Result;

                return new VechicleInfo
                {
                    VechicleType = data.Split(";")[0],
                    Weight = int.Parse(data.Split(";")[1]),
                    Hour = int.Parse(data.Split(";")[2])
                };
            }
        }
    }
}
