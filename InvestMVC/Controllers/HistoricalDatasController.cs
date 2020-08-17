using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using InvestMVC.Data;
using InvestMVC.Models;

namespace InvestMVC.Controllers
{
    public class HistoricalDatasController : Controller
    {
        private readonly InvestMVCContext _context;

        public HistoricalDatasController(InvestMVCContext context)
        {
            _context = context;
        }

        // GET: HistoricalDatas
        public async Task<IActionResult> Index()
        {
            return View(await _context.HistoricalData.ToListAsync());
        }

        // GET: HistoricalDatas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var historicalData = await _context.HistoricalData
                .FirstOrDefaultAsync(m => m.Id == id);
            if (historicalData == null)
            {
                return NotFound();
            }

            return View(historicalData);
        }

        // GET: HistoricalDatas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HistoricalDatas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id")] HistoricalData historicalData)
        {
            if (ModelState.IsValid)
            {
                _context.Add(historicalData);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(historicalData);
        }

        // GET: HistoricalDatas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var historicalData = await _context.HistoricalData.FindAsync(id);
            if (historicalData == null)
            {
                return NotFound();
            }
            return View(historicalData);
        }

        // POST: HistoricalDatas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id")] HistoricalData historicalData)
        {
            if (id != historicalData.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(historicalData);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HistoricalDataExists(historicalData.Id))
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
            return View(historicalData);
        }

        // GET: HistoricalDatas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var historicalData = await _context.HistoricalData
                .FirstOrDefaultAsync(m => m.Id == id);
            if (historicalData == null)
            {
                return NotFound();
            }

            return View(historicalData);
        }

        // POST: HistoricalDatas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var historicalData = await _context.HistoricalData.FindAsync(id);
            _context.HistoricalData.Remove(historicalData);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HistoricalDataExists(int id)
        {
            return _context.HistoricalData.Any(e => e.Id == id);
        }
    }
}
