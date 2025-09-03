using Microsoft.AspNetCore.Mvc;

namespace WebsiteCms.Controllers
{
    public class EHSController : Controller
    {
        public IActionResult Index() => View();
        public IActionResult Procedures() => View();
        public IActionResult Instructions() => View();
        public IActionResult Manual() => View();
        public IActionResult Policy() => View();
    }
}
