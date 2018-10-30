using Tolly.Domain.Models;

namespace Tolly.Domain.Services
{
    public interface ITollCalculator
    {
        ResultFromCalculation Calculate(string item);
    }
}