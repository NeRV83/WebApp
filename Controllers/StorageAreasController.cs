using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataLayer;

namespace RailParts___WebApp.Controllers
{
    public class StorageAreasController : Controller
    {
        private readonly EFDBContext _context;

        public StorageAreasController(EFDBContext context)
        {
            _context = context;
        }

        // GET: StorageAreas
        public async Task<IActionResult> Index()
        {
            return View(await _context.StorageArea.ToListAsync());
        }

        // GET: StorageAreas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var storageArea = await _context.StorageArea
                .FirstOrDefaultAsync(m => m.StorageAreaId == id);
            if (storageArea == null)
            {
                return NotFound();
            }

            return View(storageArea);
        }

        // GET: StorageAreas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: StorageAreas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StorageAreaId,Name,Adress,Phone,Email,INN,KPP,Capacity,Area")] StorageArea storageArea)
        {
            if (ModelState.IsValid)
            {
                _context.Add(storageArea);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(storageArea);
        }

        // GET: StorageAreas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var storageArea = await _context.StorageArea.FindAsync(id);
            if (storageArea == null)
            {
                return NotFound();
            }
            return View(storageArea);
        }

        // POST: StorageAreas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("StorageAreaId,Name,Adress,Phone,Email,INN,KPP,Capacity,Area")] StorageArea storageArea)
        {
            if (id != storageArea.StorageAreaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(storageArea);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StorageAreaExists(storageArea.StorageAreaId))
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
            return View(storageArea);
        }

        // GET: StorageAreas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var storageArea = await _context.StorageArea
                .FirstOrDefaultAsync(m => m.StorageAreaId == id);
            if (storageArea == null)
            {
                return NotFound();
            }

            return View(storageArea);
        }

        // POST: StorageAreas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var storageArea = await _context.StorageArea.FindAsync(id);
            _context.StorageArea.Remove(storageArea);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StorageAreaExists(int id)
        {
            return _context.StorageArea.Any(e => e.StorageAreaId == id);
        }
    }
}
