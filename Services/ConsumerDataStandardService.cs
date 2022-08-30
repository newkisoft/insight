using insight.Models;

namespace insight.Services;
public class ConsumerDataStandardService : IConsumerDataStandardService
{    
    public ConsumerDataStandardService()
    {
        
    }
    public Data Effective()
    {         
        return new Data();        
    }
}

