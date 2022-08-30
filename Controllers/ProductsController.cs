using Microsoft.AspNetCore.Mvc;
using insight.Services;
using insight.Models;
using insight.Attributes;

namespace insight.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{

    private readonly ILogger<ProductsController> _logger;
    private readonly IConsumerDataStandardService _consumerStandardService;

    public ProductsController(ILogger<ProductsController> logger,IConsumerDataStandardService consumerDataStandardService )
    {
        _logger = logger;
        _consumerStandardService = consumerDataStandardService;
    }

    [HttpGet]
    [HeaderValidation]
    public ProductResponse Get()
    {       
        return new ProductResponse{ Data =  _consumerStandardService.Effective()};
    }
}
