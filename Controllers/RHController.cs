using Microsoft.AspNetCore.Mvc;

namespace WebsiteCms.Controllers
{
    public class RHController : Controller
    {
        public IActionResult Index() => View();
        public IActionResult Documents() => View();
        public IActionResult Procedures() => View();
        public IActionResult Instructions() => View();
        public IActionResult JobDescription() => View();
        public IActionResult SupplyChain() => View();
        public IActionResult Fiat() => View();
        public IActionResult Organigramme() => View();
        public IActionResult Policy() => View();
    }
}
