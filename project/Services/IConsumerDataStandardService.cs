
using Enums;
using insight.Models;

namespace insight.Services;
public interface IConsumerDataStandardService
{   
    IEnumerable<Product>  GetProducts(Effective? effective);
    int Count();
}