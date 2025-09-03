using Microsoft.AspNetCore.Mvc;
namespace YazakiPortalFull.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
    }
}
