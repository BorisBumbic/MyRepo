using System;
using Tolly.Domain.Models;

namespace Tolly.Domain.Services
{
    public class TollCalculator : ITollCalculator
    {
        private readonly IVechicleReader _reader;

        public TollCalculator(IVechicleReader reader)
        {
            _reader = reader;
        }

        public ResultFromCalculation Calculate(string item)
        {
            VechicleInfo vi = _reader.Read(item);

            // Beräkna pris

            decimal startFee = 10; 
            decimal priceFactor = 1;

            switch (vi.VechicleType)
            {
                case "bil":
                    priceFactor *= 1;
                    break;
                case "lastbil":
                    priceFactor *= 2;
                    break;
                case "miljöbil":
                    priceFactor = 0;
                    break;
                default: throw new Exception("Unknown vehicle type");
            }

            if (vi.Weight < 0)
                throw new Exception("Can't have negative weight");

            if (vi.Weight > 1000)
                priceFactor *= 1.5M;

            if (vi.Hour < 0 || vi.Hour > 24)
                throw new Exception("Invalid hour");

            if (vi.Hour >= 8 && vi.Hour <= 17)
                priceFactor *= 1.2M;

            decimal totalPrice = startFee * priceFactor;

            return new ResultFromCalculation
            {
                Hour = vi.Hour,
                TotalPrice = totalPrice,
                VehicleType = vi.VechicleType,
                Weight = vi.Weight
            };
        }
    }
}
