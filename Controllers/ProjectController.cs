using Microsoft.AspNetCore.Mvc;
using WebsiteCms.Services;

namespace WebsiteCms.Controllers
{
    public class ProjectController : Controller
    {
        public IActionResult Launch() => View("DocumentTable", DocumentSeed.GetDocuments().GetValueOrDefault("Project-Launch"));
    }
}
