namespace WebApplication1.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using WebApplication1.Models;

    public class HomeController : Controller
    {
        [Route("Home/Details")]
        public JsonResult Details(int id)
        {
            return Json(_employeeRepository.GetById(id));
        }

        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        private readonly IEmployeeRepository _employeeRepository;
    }
}
