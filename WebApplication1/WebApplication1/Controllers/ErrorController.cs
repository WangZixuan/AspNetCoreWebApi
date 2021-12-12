using System;
using System.Net;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class ErrorController : Controller
    {
        [Route("/Error/{statusCode}")]
        public JsonResult HandleError(int statusCode)
        {
            HttpStatusCode httpStatusCode = (HttpStatusCode)statusCode;
            return new JsonResult(new { Message = httpStatusCode.ToString() });
        }

        [Route("Error")]
        public JsonResult Error()
        {
            var exceptionDetails = HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            return new JsonResult(new { exceptionDetails?.Error.StackTrace  });
        }
    }
}

