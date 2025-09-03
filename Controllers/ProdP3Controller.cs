using Microsoft.AspNetCore.Mvc;
using WebsiteCms.Services;

namespace WebsiteCms.Controllers
{
    public class ProdController : Controller
    {
        public IActionResult P1P2() => View("DocumentTable", DocumentSeed.GetDocuments().GetValueOrDefault("Prod-P1P2"));
        public IActionResult P3() => View("DocumentTable", DocumentSeed.GetDocuments().GetValueOrDefault("Prod-P3"));
    }
}
