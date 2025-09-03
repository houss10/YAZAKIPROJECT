using Microsoft.AspNetCore.Mvc;
using WebsiteCms.Services;

namespace WebsiteCms.Controllers
{
    public class LogisticController : Controller
    {
        public IActionResult Index() => View();
        public IActionResult Procedures() => View("DocumentTable", DocumentSeed.GetDocuments().GetValueOrDefault("Logistic-Procedures"));
        public IActionResult Instructions() => View("DocumentTable", DocumentSeed.GetDocuments().GetValueOrDefault("Instructions-Procedures"));
    }
}
