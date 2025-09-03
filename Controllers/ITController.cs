using Microsoft.AspNetCore.Mvc;

namespace WebsiteCms.Controllers
{
    public class ITController : Controller
    {
        public IActionResult Index() => View();
        public IActionResult Procedures() => View();
        public IActionResult Forms() => View();
        public IActionResult Telephonie() => View();
        public IActionResult Voip() => View();
        public IActionResult Mobile() => View();
    }
}
