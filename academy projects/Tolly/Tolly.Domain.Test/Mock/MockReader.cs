using System;
using Tolly.Domain.Models;
using Tolly.Domain.Services;

namespace Tolly.Domain.Test.Mock
{
    public class MockReader : IVechicleReader
    {
        public VechicleInfo Read(string item)
        {
            switch (item)
            {
                case "bil_800kg_kl6":
                    return new VechicleInfo
                    {
                        VechicleType = "bil",
                        Weight = 800,
                        Hour = 6
                    };

                case "lastbil_1600kg_kl15":
                    return new VechicleInfo
                    {
                        VechicleType = "lastbil",
                        Weight = 1600,
                        Hour = 15
                    };
                default: throw new Exception("Unknown item");
            }
        }
    }
}
