using Microsoft.AspNetCore.Mvc;
using ContactApp.Data;
using ContactApp.Models;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace ContactApp.Controllers
{
    public class ContactController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly ILogger<ContactController> _logger;

        public ContactController(ApplicationDbContext db, ILogger<ContactController> logger)
        {
            _db = db;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new ContactMessage());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(ContactMessage model)
        {
            if (!ModelState.IsValid)
                return View(model);

            try
            {
                model.SubmittedAt = DateTime.UtcNow;
                _db.ContactMessages.Add(model);
                await _db.SaveChangesAsync();

                TempData["Success"] = "İletişiminiz başarıyla gönderildi.";
                return RedirectToAction(nameof(Thanks));
            }
            catch (System.Exception ex)
            {
                _logger.LogError(ex, "Contact save error");
                ModelState.AddModelError("", "Kayıt sırasında hata oluştu. Lütfen daha sonra tekrar deneyin.");
                return View(model);
            }
        }

        [HttpGet]
        public IActionResult Thanks()
        {
            return View();
        }
    }
}
