using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;

namespace As.Core.MVC.FilterRedirection;

	public class MyRedirectionFilter : Attribute, IActionFilter
{
    public string Controller { get; set; }
    public string Action { get; set; }

    public void OnActionExecuting(ActionExecutingContext context)
    {
        if (context.HttpContext.Request.Headers.Keys.Contains("x-mobile"))
        {
            context.Result = new RedirectToActionResult(Action, Controller, null);
        }
    }

    //if redirected, this will not be called
    public void OnActionExecuted(ActionExecutedContext context)
    {
        Debug.WriteLine("Action Executed");
    }
}
