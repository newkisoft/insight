using Microsoft.AspNetCore.Mvc;
using insight.Services;
using insight.Models;
using insight.Attributes;
using Enums;

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

    [HttpGet()]
    [ServiceFilter(typeof(HeaderValidation))]
    public ActionResult Get(Effective? effective, DateTimeOffset? updatedSince, string? brand, ProductCategory? productCategory, int? page,int pageSize=25)
    {       
        if(page.HasValue && page<1)
        {            
            return BadRequest("Page should be greater than zero");
        }

        if(pageSize<1)
        {            
            return BadRequest("Page size should be greater than zero");
        }

        var products = _consumerStandardService.GetProducts();
        var data = new Data();        
        data.Products = products;
        data.Meta = new Meta{TotalPages= data.Products.Count/pageSize, TotalRecords = data.Products.Count };

        if(page>data.Meta.TotalPages)
        {
            return StatusCode(StatusCodes.Status422UnprocessableEntity,$"Page number should less than {data.Meta.TotalPages}");
        }

        return Ok(new ProductResponse{ Data =  data});
    }
}
