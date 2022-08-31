using FizzWare.NBuilder;
using insight.Models;

namespace insight.Services;
public class ConsumerDataStandardService : IConsumerDataStandardService
{    
    private IList<Product> products = new List<Product>();
    public ConsumerDataStandardService()
    {
        products = Builder<Product>.CreateListOfSize(100).Build();
    }

    public int Count()
    {
        return products.Count;      

    }

    public IList<Product> GetProducts()
    {         
        return products;        
    }
}

