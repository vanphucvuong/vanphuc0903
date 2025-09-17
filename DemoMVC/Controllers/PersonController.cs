using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class PersonController : Controller
    {
        // GET: /Person/Index
        public IActionResult Index()
        {
            return View();
        }

        // GET: /Person/Details
        public IActionResult Details()
        {
            return View();
        }
    }
}
