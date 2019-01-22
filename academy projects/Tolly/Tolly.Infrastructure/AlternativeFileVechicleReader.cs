using System;
using System.Collections.Generic;
using System.Text;
using Tolly.Domain.Models;
using Tolly.Domain.Services;

namespace Tolly.Infrastructure
{
    public class AlternativeFileVechicleReader : IVechicleReader
    {
        public VechicleInfo Read(string item)
        {
            string data = System.IO.File.ReadAllText("DataAlternative/" + item + ".txt");

            string tempValue = data.Split("-")[1];
            string tempString = null;

            if (tempValue == "L")
                tempString = "Lastbil";
            else if (tempValue == "B")
                tempString = "Bil";

            return new VechicleInfo
            {
                VechicleType = tempString,
                Weight = int.Parse(data.Split("-")[0]),
                Hour = int.Parse(data.Split("-")[2])
            };
        }
    }
}
