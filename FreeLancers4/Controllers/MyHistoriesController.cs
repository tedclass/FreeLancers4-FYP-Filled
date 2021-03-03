using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FreeLancers4.Data;
using FreeLancers4.Models;

namespace FreeLancers4.Views.MyHistories
{
    public class MyHistoriesController : Controller
    {
        private readonly FreeLancers4NewContext _context;

        public MyHistoriesController(FreeLancers4NewContext context)
        {
            _context = context;
        }

        // GET: MyHistories
        public async Task<IActionResult> Index()
        {
            return View(await _context.MyHistory.ToListAsync());
        }

        // GET: MyHistories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var myHistory = await _context.MyHistory
                .FirstOrDefaultAsync(m => m.ID == id);
            if (myHistory == null)
            {
                return NotFound();
            }

            return View(myHistory);
        }

        // GET: MyHistories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MyHistories/Create
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,ProjectName,Description,Freelancer,Rating,DeliveredOn")] MyHistory myHistory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(myHistory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(myHistory);
        }

        // GET: MyHistories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var myHistory = await _context.MyHistory.FindAsync(id);
            if (myHistory == null)
            {
                return NotFound();
            }
            return View(myHistory);
        }

        // POST: MyHistories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,ProjectName,Description,Freelancer,Rating,DeliveredOn")] MyHistory myHistory)
        {
            if (id != myHistory.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(myHistory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MyHistoryExists(myHistory.ID))
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
            return View(myHistory);
        }

        // GET: MyHistories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var myHistory = await _context.MyHistory
                .FirstOrDefaultAsync(m => m.ID == id);
            if (myHistory == null)
            {
                return NotFound();
            }

            return View(myHistory);
        }

        // POST: MyHistories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var myHistory = await _context.MyHistory.FindAsync(id);
            _context.MyHistory.Remove(myHistory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MyHistoryExists(int id)
        {
            return _context.MyHistory.Any(e => e.ID == id);
        }
    }
}
