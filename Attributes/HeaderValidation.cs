using System.ComponentModel.DataAnnotations;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace insight.Attributes;

public class HeaderValidation: ActionFilterAttribute
{
    public HeaderValidation()
    {
        
    }

   public override void OnActionExecuting(ActionExecutingContext context)
    {        
        if (context.HttpContext.Request.Headers["x-v"] != "v3")
        {
            context.Result = new BadRequestObjectResult("x-v is missing");
        }        
    }
}