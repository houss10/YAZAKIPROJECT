using Microsoft.AspNetCore.Mvc;

namespace WebsiteCms.Controllers
{
    public class EngineeringController : Controller
    {
        public IActionResult Index() => View();
        public IActionResult Procedures() => View();
        public IActionResult Normes() => View();
        public IActionResult Fiat() => View();
        public IActionResult BMW() => View();
    }
}
