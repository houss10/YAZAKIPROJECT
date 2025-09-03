using Microsoft.AspNetCore.Mvc;
using WebsiteCms.Services;

namespace WebsiteCms.Controllers
{
    public class FinanceController : Controller
    {
        public IActionResult Index() => View();
        public IActionResult Procedures() => View("DocumentTable", DocumentSeed.GetDocuments().GetValueOrDefault("Finance-Procedures"));
        public IActionResult Instructions() => View("DocumentTable", DocumentSeed.GetDocuments().GetValueOrDefault("Finance-Instructions"));
    }
}
