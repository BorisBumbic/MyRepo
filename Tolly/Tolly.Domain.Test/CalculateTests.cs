using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tolly.Domain.Services;
using Tolly.Domain.Test.Mock;

namespace Tolly.Domain.Test
{
    [TestClass]
    public class CalculateTests
    {
        [TestMethod]
        public void should_be_10kr_when_car_is_passed_at_6_with_weight_800kg()
        {
            var t = new TollCalculator(new MockReader());
            var result = t.Calculate("bil_800kg_kl6");

            Assert.AreEqual(10, result.TotalPrice);

            // Kan även assert'a:

            Assert.AreEqual("bil", result.VehicleType);
            Assert.AreEqual(800, result.Weight);
            Assert.AreEqual(6, result.Hour);

        }

        [TestMethod]
        public void should_be_36kr_when_truck_is_passed_at_15_with_weight_1600kg()
        {
            var t = new TollCalculator(new MockReader());
            var result = t.Calculate("lastbil_1600kg_kl15");

            Assert.AreEqual(36, result.TotalPrice);
        }

        [TestMethod]
        public void should_be_3600kr_when_truck_is_passed_at_15_with_weight_1600kg_with_expensive_toll_calculator()
        {
            throw new NotImplementedException();
        }
    }
}
