using Microsoft.AspNetCore.Mvc;
using WebsiteCms.Models;
using WebsiteCms.Services;

namespace WebsiteCms.Controllers
{
    public class QualityController : Controller
    {
        public IActionResult Instruction()
        {
            var docs = DocumentSeed.GetDocuments()["Instruction"];
            return View(docs);
        }

        public IActionResult Procedure()
        {
            var docs = DocumentSeed.GetDocuments()["Procedure"];
            if (docs == null || !docs.Any())
            {
                // Handle case where no documents were found
                Console.WriteLine("No documents found for 'Procedure'.");
                return View("Error");  // You can return a custom error page or show a friendly message in the view
            }
            return View(docs);
        }

        public IActionResult Lab()
        {

            var docs = DocumentSeed.GetDocuments()["Lab"];
            return View(docs);
        }
        public IActionResult Customer()
        {

            var docs = DocumentSeed.GetDocuments()["Customer"];
            return View(docs);
        }
        public IActionResult P1P2()
        {

            var docs = DocumentSeed.GetDocuments()["P1P2"];
            return View(docs);
        }
        public IActionResult P3()
        {

            var docs = DocumentSeed.GetDocuments()["P3"];
            return View(docs);
        }
    }
}
