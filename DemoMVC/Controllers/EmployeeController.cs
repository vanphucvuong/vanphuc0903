using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: /Employee/Index
        public IActionResult Index()
        {
            return View();
        }

        // GET: /Employee/Profile
        public IActionResult Profile()
        {
            return View();
        }
    }
}
