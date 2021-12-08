namespace WebApplication1.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using WebApplication1.Models;

    [Route("[controller]")]
    public class HomeController : Controller
    {
        [Route("")]
        [Route("[action]")]
        [Route("/")] // or [Route("~/")]
        public JsonResult Index()
        {
            return Json(_employeeRepository.GetById(0));
        }

        [Route("[action]/{id?}")]
        public JsonResult Details(int id)
        {
            // id will be 0 if not giben
            return Json(_employeeRepository.GetById(id));
        }

        public JsonResult Details2(int? id)
        {
            // id will be null if not given
            return Json(_employeeRepository.GetById(id??0));
        }

        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        private readonly IEmployeeRepository _employeeRepository;
    }
}
