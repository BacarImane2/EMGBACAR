using EMGBACAR.Data;
using EMGBACAR.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EMGBACAR.Controllers
{
    public class VoitureController : Controller
    {
        private readonly ApplicationDbContext _context;

        public VoitureController(ApplicationDbContext context)
        {
            _context = context;
        }
        
        // GET: Voiture/Index
        public async Task<IActionResult> Index()
        {
            var voitures = await _context.Voitures.Include(v => v.Marque).ToListAsync();
            return View(voitures);
        }

        // GET: Voiture/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var voiture = await _context.Voitures
                .Include(v => v.Marque)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (voiture == null) return NotFound();

            return View(voiture);
        }

        // GET: Voiture/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var voiture = await _context.Voitures.FindAsync(id);
            if (voiture == null) return NotFound();

            // Charger les marques pour la liste déroulante
            ViewBag.Marques = await _context.Marques.ToListAsync();
            return View(voiture);
        }

        // POST: Voiture/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Voiture voiture)
        {
            if (id != voiture.Id) return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(voiture);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.Voitures.Any(e => e.Id == voiture.Id))
                        return NotFound();
                    throw;
                }
                return RedirectToAction(nameof(Index));
            }

            ViewBag.Marques = await _context.Marques.ToListAsync();
            return View(voiture);
        }

        /// GET: Voiture/Delete/5
public async Task<IActionResult> Delete(int? id)
{
    if (id == null)
        return NotFound();

    var voiture = await _context.Voitures
        .Include(v => v.Marque)
        .FirstOrDefaultAsync(m => m.Id == id);

    if (voiture == null)
        return NotFound();

    return View(voiture);
}

// POST: Voiture/DeleteConfirmed/5
[HttpPost]
[ValidateAntiForgeryToken]
public async Task<IActionResult> DeleteConfirmed(int id)
{
    var voiture = await _context.Voitures.FindAsync(id);
    if (voiture != null)
    {
        _context.Voitures.Remove(voiture);
        await _context.SaveChangesAsync();
    }

    return RedirectToAction(nameof(Index));
}

         public IActionResult Create()
        {
            ViewBag.Marques = _context.Marques.ToList(); // Charger les marques pour la liste déroulante
            return View();
        }

        // POST: Voiture/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Voiture voiture)
        {
            if (ModelState.IsValid)
            {
                _context.Add(voiture);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index)); // Redirection vers Home/Index après création
            }

            ViewBag.Marques = _context.Marques.ToList(); // Recharger les marques en cas d'erreur
            return View(voiture);
        }
    
    }
}
