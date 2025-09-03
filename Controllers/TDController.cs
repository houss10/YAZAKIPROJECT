using Microsoft.AspNetCore.Mvc;
using WebsiteCms.Services;
using WebsiteCms.Models;


namespace WebsiteCms.Controllers
{
    public class TDController : Controller
    {
        public IActionResult Index() => View("DocumentTable", DocumentSeed.GetDocuments().GetValueOrDefault("TD-Procedures"));

        public IActionResult Procedures() => View("DocumentTable", DocumentSeed.GetDocuments().GetValueOrDefault("TD-Procedures"));

        public IActionResult Instructions() => View("DocumentTable", DocumentSeed.GetDocuments().GetValueOrDefault("TD-Instructions"));

        public IActionResult TPME() => View("DocumentTable", DocumentSeed.GetDocuments().GetValueOrDefault("TD-TPME"));

        public IActionResult TPMEP1() => View("DocumentTable", DocumentSeed.GetDocuments().GetValueOrDefault("TD-TPMEP1"));

        public IActionResult TPMEP2() => View("DocumentTable", DocumentSeed.GetDocuments().GetValueOrDefault("TD-TPMEP2"));

        public IActionResult TPMEP3() => View("DocumentTable", DocumentSeed.GetDocuments().GetValueOrDefault("TD-TPMEP3"));
    }
}
