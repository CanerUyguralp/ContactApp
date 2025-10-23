using Microsoft.AspNetCore.Mvc;
using ContactApp.Data;
using Microsoft.EntityFrameworkCore;

namespace ContactApp.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _db;
        public AdminController(ApplicationDbContext db)
        {
            _db = db;
        }

        // GET: /Admin
        public async Task<IActionResult> Index()
        {
            var list = await _db.ContactMessages
                                .OrderByDescending(x => x.SubmittedAt)
                                .ToListAsync();
            return View(list);
        }

        // POST: /Admin/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var item = await _db.ContactMessages.FindAsync(id);
            if (item == null) return NotFound();

            _db.ContactMessages.Remove(item);
            await _db.SaveChangesAsync();
            TempData["Success"] = "Kayıt silindi.";
            return RedirectToAction(nameof(Index));
        }
    }
}
