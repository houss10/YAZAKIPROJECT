using Microsoft.AspNetCore.Mvc;
using WebsiteCms.Services;

namespace WebsiteCms.Controllers
{
    public class SQAController : Controller
    {
        public IActionResult Index() => View("DocumentTable", DocumentSeed.GetDocuments().GetValueOrDefault("SQA - Index"));
    }
}
