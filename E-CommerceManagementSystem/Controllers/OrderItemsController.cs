using E_CommerceManageMentSystem.Data;
using E_CommerceManageMentSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace E_CommerceManageMentSystem.Controllers
{
    public class OrderItemsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OrderItemsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: OrderItems
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.OrderItems.Include(oi => oi.Order).Include(oi => oi.Variant);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: OrderItems/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderItem = await _context.OrderItems
                .Include(oi => oi.Order)
                .Include(oi => oi.Variant)
                .FirstOrDefaultAsync(m => m.OrderItemID == id);
            if (orderItem == null)
            {
                return NotFound();
            }

            return View(orderItem);
        }

        // GET: OrderItems/Create
        public IActionResult Create()
        {
            ViewData["OrderID"] = new SelectList(_context.Orders, "OrderID", "OrderID");
            ViewData["VariantID"] = new SelectList(_context.Variants, "VariantID", "VariantID");
            return View();
        }

        // POST: OrderItems/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OrderItemID,OrderID,VariantID,Quantity,Price")] OrderItem orderItem)
        {
            if (ModelState.IsValid)
            {
                _context.Add(orderItem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["OrderID"] = new SelectList(_context.Orders, "OrderID", "OrderID", orderItem.OrderID);
            ViewData["VariantID"] = new SelectList(_context.Variants, "VariantID", "VariantID", orderItem.VariantID);
            return View(orderItem);
        }

        // GET: OrderItems/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderItem = await _context.OrderItems.FindAsync(id);
            if (orderItem == null)
            {
                return NotFound();
            }
            ViewData["OrderID"] = new SelectList(_context.Orders, "OrderID", "OrderID", orderItem.OrderID);
            ViewData["VariantID"] = new SelectList(_context.Variants, "VariantID", "VariantID", orderItem.VariantID);
            return View(orderItem);
        }

        // POST: OrderItems/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrderItemID,OrderID,VariantID,Quantity,Price")] OrderItem orderItem)
        {
            if (id != orderItem.OrderItemID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(orderItem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderItemExists(orderItem.OrderItemID))
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
            ViewData["OrderID"] = new SelectList(_context.Orders, "OrderID", "OrderID", orderItem.OrderID);
            ViewData["VariantID"] = new SelectList(_context.Variants, "VariantID", "VariantID", orderItem.VariantID);
            return View(orderItem);
        }

        // GET: OrderItems/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderItem = await _context.OrderItems
                .Include(oi => oi.Order)
                .Include(oi => oi.Variant)
                .FirstOrDefaultAsync(m => m.OrderItemID == id);
            if (orderItem == null)
            {
                return NotFound();
            }

            return View(orderItem);
        }

        // POST: OrderItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var orderItem = await _context.OrderItems.FindAsync(id);
            _context.OrderItems.Remove(orderItem);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrderItemExists(int id)
        {
            return _context.OrderItems.Any(e => e.OrderItemID == id);
        }
    }
}
