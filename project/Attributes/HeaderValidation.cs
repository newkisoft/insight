using insight.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Options;

namespace insight.Attributes;

public class HeaderValidation: ActionFilterAttribute
{
     private SupprtingVersion _supprtingVersion;
    public HeaderValidation(IOptions<SupprtingVersion> options)
    {    
         _supprtingVersion = options.Value;
    }

   public override void OnActionExecuting(ActionExecutingContext context)
    {     
                   
        var headers = context.HttpContext.Request.Headers;
        if (headers.Keys.Contains("x-v"))
        {            
            int xv;
            int.TryParse(headers["x-v"], out xv);
            int xvmin = 0;
            if (headers.Keys.Contains("x-min-v"))
            {
               int.TryParse(headers["x-min-v"],out xvmin);               
            }            

            if(xv <= _supprtingVersion.LatestVersion || xv>=_supprtingVersion.MinVersion)
            {
                return;
            }
        }   
        context.Result = new StatusCodeResult(StatusCodes.Status406NotAcceptable);     
    }
}