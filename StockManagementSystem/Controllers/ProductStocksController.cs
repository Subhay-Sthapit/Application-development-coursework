using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StockManagementSystem.Data;
using StockManagementSystem.Models;

namespace StockManagementSystem.Controllers
{
    public class ProductStocksController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductStocksController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ProductStocks
        public async Task<IActionResult> Index()
        {
            return View(await _context.ProductStock.ToListAsync());
        }

        // GET: ProductStocks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productStock = await _context.ProductStock
                .FirstOrDefaultAsync(m => m.Id == id);
            if (productStock == null)
            {
                return NotFound();
            }

            return View(productStock);
        }

        // GET: ProductStocks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProductStocks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ProductId,Quantity")] ProductStock productStock)
        {
            if (ModelState.IsValid)
            {
                _context.Add(productStock);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(productStock);
        }

        // GET: ProductStocks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productStock = await _context.ProductStock.FindAsync(id);
            if (productStock == null)
            {
                return NotFound();
            }
            return View(productStock);
        }

        // POST: ProductStocks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ProductId,Quantity")] ProductStock productStock)
        {
            if (id != productStock.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(productStock);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductStockExists(productStock.Id))
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
            return View(productStock);
        }

        // GET: ProductStocks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productStock = await _context.ProductStock
                .FirstOrDefaultAsync(m => m.Id == id);
            if (productStock == null)
            {
                return NotFound();
            }

            return View(productStock);
        }

        // POST: ProductStocks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var productStock = await _context.ProductStock.FindAsync(id);
            _context.ProductStock.Remove(productStock);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductStockExists(int id)
        {
            return _context.ProductStock.Any(e => e.Id == id);
        }
    }
}
