
using Tolly.Domain.Models;

namespace Tolly.Domain.Services
{
    public interface IVechicleReader
    {
        VechicleInfo Read(string item);
    }
}
