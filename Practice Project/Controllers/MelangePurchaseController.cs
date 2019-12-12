using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Practice_Project.Data;
using Practice_Project.Models;

namespace Practice_Project.Controllers
{
    public class MelangePurchaseController : Controller
    {
        private readonly MelangePurchaseContext _context;

        public MelangePurchaseController(MelangePurchaseContext context)
        {
            _context = context;
        }

        // GET: MelangePurchase
        public async Task<IActionResult> Index()
        {
            return View(await _context.MelangePurchase.ToListAsync());
        }

        // GET: MelangePurchase/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var melangePurchase = await _context.MelangePurchase
                .FirstOrDefaultAsync(m => m.Id == id);
            if (melangePurchase == null)
            {
                return NotFound();
            }

            return View(melangePurchase);
        }

        // GET: MelangePurchase/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MelangePurchase/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,MerchantName,PurchaseDate,Kilos,Price")] MelangePurchase melangePurchase)
        {
            if (ModelState.IsValid)
            {
                _context.Add(melangePurchase);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(melangePurchase);
        }

        // GET: MelangePurchase/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var melangePurchase = await _context.MelangePurchase.FindAsync(id);
            if (melangePurchase == null)
            {
                return NotFound();
            }
            return View(melangePurchase);
        }

        // POST: MelangePurchase/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,MerchantName,PurchaseDate,Kilos,Price")] MelangePurchase melangePurchase)
        {
            if (id != melangePurchase.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(melangePurchase);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MelangePurchaseExists(melangePurchase.Id))
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
            return View(melangePurchase);
        }

        // GET: MelangePurchase/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var melangePurchase = await _context.MelangePurchase
                .FirstOrDefaultAsync(m => m.Id == id);
            if (melangePurchase == null)
            {
                return NotFound();
            }

            return View(melangePurchase);
        }

        // POST: MelangePurchase/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var melangePurchase = await _context.MelangePurchase.FindAsync(id);
            _context.MelangePurchase.Remove(melangePurchase);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MelangePurchaseExists(int id)
        {
            return _context.MelangePurchase.Any(e => e.Id == id);
        }
    }
}
