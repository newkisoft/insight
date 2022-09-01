using insight.Services;

namespace project.test;

public class ConsumerDataStandardServiceTest
{
    private readonly ConsumerDataStandardService _consumerDataStandardService;

    public ConsumerDataStandardServiceTest()
    {
        _consumerDataStandardService = new ConsumerDataStandardService();
    }


    [Fact]
    public void TestGetAllWihtoutFilter()
    {        
        var result = _consumerDataStandardService.GetProducts(null);
        Assert.Equal(result.Count(),100);      
    }

    [Fact]
    public void TestGetAllWithEffectiveFilter()
    {        
        var result = _consumerDataStandardService.GetProducts(Enums.Effective.CURRENT);
        Assert.Equal(result.Count(), 2);      
    }
}