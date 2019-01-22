using Tolly.Domain.Models;
using Tolly.Domain.Services;

namespace Tolly.Infrastructure
{
    public class FileVechicleReader : IVechicleReader
    {
        public VechicleInfo Read(string item)
        {
            string data = System.IO.File.ReadAllText("Data/" + item + ".txt");

            return new VechicleInfo
            {
                VechicleType = data.Split(";")[0],
                Weight = int.Parse(data.Split(";")[1]),
                Hour = int.Parse(data.Split(";")[2])
            };
        }
    }
}
