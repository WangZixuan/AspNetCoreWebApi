namespace WebApplication1.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using WebApplication1.Models;

    public class HomeController : Controller
    {
        public JsonResult Index(int i)
        {
            return Json(_employeeRepository.GetById(i));
        }

        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        private readonly IEmployeeRepository _employeeRepository;
    }
}
