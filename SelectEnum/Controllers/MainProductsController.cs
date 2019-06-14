using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SelectEnum.Models;

namespace SelectEnum.Controllers
{
    public class MainProductsController : Controller
    {
        private readonly DataBaseContext _context;

        public MainProductsController(DataBaseContext context)
        {
            _context = context;
        }

        // GET: MainProducts
        public async Task<IActionResult> Index()
        {
            return View(await _context.MainProducts.ToListAsync());
        }

        // GET: MainProducts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mainProduct = await _context.MainProducts
                .FirstOrDefaultAsync(m => m.MainProductID == id);
            if (mainProduct == null)
            {
                return NotFound();
            }

            return View(mainProduct);
        }

        // GET: MainProducts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MainProducts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MainProductID,Name,SubCategoryID")] MainProduct mainProduct)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mainProduct);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mainProduct);
        }

        // GET: MainProducts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mainProduct = await _context.MainProducts.FindAsync(id);
            if (mainProduct == null)
            {
                return NotFound();
            }
            return View(mainProduct);
        }

        // POST: MainProducts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MainProductID,Name,SubCategoryID")] MainProduct mainProduct)
        {
            if (id != mainProduct.MainProductID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mainProduct);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MainProductExists(mainProduct.MainProductID))
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
            return View(mainProduct);
        }

        // GET: MainProducts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mainProduct = await _context.MainProducts
                .FirstOrDefaultAsync(m => m.MainProductID == id);
            if (mainProduct == null)
            {
                return NotFound();
            }

            return View(mainProduct);
        }

        // POST: MainProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mainProduct = await _context.MainProducts.FindAsync(id);
            _context.MainProducts.Remove(mainProduct);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MainProductExists(int id)
        {
            return _context.MainProducts.Any(e => e.MainProductID == id);
        }
    }
}
