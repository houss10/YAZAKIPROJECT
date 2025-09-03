using Microsoft.AspNetCore.Mvc;
using WebsiteCms.Services;

namespace WebsiteCms.Controllers
{
    public class PurchasingController : Controller
    {
        public IActionResult Index() => View("DocumentTable", DocumentSeed.GetDocuments().GetValueOrDefault("Purchasing-Index"));
    }
}
