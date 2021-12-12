namespace WebApplication1.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using WebApplication1.Models;

    public class HomeController : Controller
    {
        public IActionResult Details(int id)
        {
            if (id > 3)
            {
                throw new Exception();
            }

            return new JsonResult(new { id, Response.StatusCode });
        }

        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        private readonly IEmployeeRepository _employeeRepository;
    }
}
