using FizzWare.NBuilder;
using insight.Controllers;
using insight.Models;
using insight.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;

namespace project.test;

public class InsightProductsControllerTest
{
    private IEnumerable<Product> _products;
    private Mock<ILogger<ProductsController>> _moqLogger;
    private Mock<IConsumerDataStandardService> _moqConsumerService;
    private ProductsController _productsController;

    public InsightProductsControllerTest()
    {
        _products = Builder<Product>.CreateListOfSize(100)
            .TheFirst(2).With(p=>p.EffectiveFrom = DateTimeOffset.Now)
            .TheNext(2).With(p=>p.EffectiveTo = DateTimeOffset.Now.AddDays(1))
            .Build();
        _moqLogger = new Mock<ILogger<ProductsController>>();
        _moqConsumerService = new Mock<IConsumerDataStandardService>();
        _moqConsumerService.Setup(p=>p.GetProducts(null)).Returns(_products);
        var now = DateTimeOffset.Now;
        _moqConsumerService.Setup(p=>p.GetProducts(Enums.Effective.CURRENT)).Returns(_products.Where(p=>p.EffectiveFrom<=now && now <= p.EffectiveTo));
        _productsController = new ProductsController(_moqLogger.Object, _moqConsumerService.Object);
    }


    [Fact]
    public void TestGetAllWihtoutFilter()
    {        
        var result = (OkObjectResult)_productsController.Get(null,null,null,null,null);        
        Assert.Equal(((ProductResponse)(result.Value)).Data.Products.Count, _products.Count());      
    }

    [Fact]
    public void TestGetAllWithEffectiveFilter()
    {
        var result = (OkObjectResult)_productsController.Get(Enums.Effective.CURRENT ,null,null,null,null);        
        Assert.Equal(((ProductResponse)(result.Value)).Data.Products.Count, 2);      
    }
}