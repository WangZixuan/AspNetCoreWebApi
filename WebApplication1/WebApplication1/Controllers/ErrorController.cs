using System;
using System.Net;
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
    }
}

