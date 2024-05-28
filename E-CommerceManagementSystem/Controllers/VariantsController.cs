using E_CommerceManageMentSystem.Data;
using E_CommerceManageMentSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace E_CommerceManageMentSystem.Controllers
{
    public class VariantsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public VariantsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Variants
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Variants.Include(v => v.Product);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Variants/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var variant = await _context.Variants
                .Include(v => v.Product)
                .FirstOrDefaultAsync(m => m.VariantID == id);
            if (variant == null)
            {
                return NotFound();
            }

            return View(variant);
        }

        // GET: Variants/Create
        public IActionResult Create()
        {
            ViewData["ProductID"] = new SelectList(_context.Products, "ProductID", "Name");
            return View();
        }

        // POST: Variants/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("VariantID,ProductID,Color,Size")] Variant variant)
        {
            if (ModelState.IsValid)
            {
                _context.Add(variant);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProductID"] = new SelectList(_context.Products, "ProductID", "Name", variant.ProductID);
            return View(variant);
        }

        // GET: Variants/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var variant = await _context.Variants.FindAsync(id);
            if (variant == null)
            {
                return NotFound();
            }
            ViewData["ProductID"] = new SelectList(_context.Products, "ProductID", "Name", variant.ProductID);
            return View(variant);
        }

        // POST: Variants/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("VariantID,ProductID,Color,Size")] Variant variant)
        {
            if (id != variant.VariantID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(variant);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VariantExists(variant.VariantID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProductID"] = new SelectList(_context.Products, "ProductID", "Name", variant.ProductID);
            return View(variant);
        }

        // GET: Variants/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var variant = await _context.Variants
                .Include(v => v.Product)
                .FirstOrDefaultAsync(m => m.VariantID == id);
            if (variant == null)
            {
                return NotFound();
            }

            return View(variant);
        }

        // POST: Variants/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var variant = await _context.Variants.FindAsync(id);
            _context.Variants.Remove(variant);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VariantExists(int id)
        {
            return _context.Variants.Any(e => e.VariantID == id);
        }
    }
}
