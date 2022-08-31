
using insight.Models;

namespace insight.Services;
public interface IConsumerDataStandardService
{   
    IList<Product> GetProducts();
    int Count();
}