using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebsiteCms.Models;
using WebsiteCms.Services;

namespace WebsiteCms.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class DocumentsController : Controller
    {
        private readonly ApplicationDbContext _db;

        public DocumentsController(ApplicationDbContext db) => _db = db;

        // GET: /Admin/Documents
        public async Task<IActionResult> Index(string? category)
        {
            ViewBag.Category = category;
            var query = _db.Documents.AsQueryable();

            if (!string.IsNullOrWhiteSpace(category))
                query = query.Where(d => d.Category == category);

            var items = await query
                .OrderBy(d => d.Category).ThenBy(d => d.Number)
                .ToListAsync();

            return View(items);
        }

        // GET: /Admin/Documents/Create
        public IActionResult Create(string? category)
        {
            var model = new ADocumentModel
            {
                IssueDate = DateTime.Today,
                Category = category ?? ""
            };
            return View(model);
        }

        // POST: /Admin/Documents/Create
        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ADocumentModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            _db.Documents.Add(model);
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index),
                new { area = "Admin", category = model.Category }); // 👈 keep area
        }

        // GET: /Admin/Documents/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var doc = await _db.Documents.FindAsync(id);
            if (doc == null) return NotFound();
            return View(doc);
        }

        // POST: /Admin/Documents/Edit/5
        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, ADocumentModel model)
        {
            if (id != model.Id) return BadRequest();
            if (!ModelState.IsValid) return View(model);

            _db.Update(model);
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index),
                new { area = "Admin", category = model.Category }); // 👈 keep area
        }

        // GET: /Admin/Documents/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var doc = await _db.Documents.FindAsync(id);
            if (doc == null) return NotFound();
            return View(doc);
        }

        // POST: /Admin/Documents/Delete/5
        [HttpPost, ActionName("Delete"), ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var doc = await _db.Documents.FindAsync(id);
            if (doc == null) return NotFound();

            var category = doc.Category;
            _db.Documents.Remove(doc);
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index),
                new { area = "Admin", category }); // 👈 keep area
        }

        // GET: /Admin/Documents/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var doc = await _db.Documents.FindAsync(id);
            if (doc == null) return NotFound();
            return View(doc);
        }
    }
}
