using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using tsport.Data;
using tsport.Models;

namespace tsport.Controllers
{
    public class TransportersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TransportersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Transporters
        public async Task<IActionResult> Index()
        {
            return View(await _context.Transporter.ToListAsync());
        }

        // GET: Transporters/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transporter = await _context.Transporter
                .FirstOrDefaultAsync(m => m.Id == id);
            if (transporter == null)
            {
                return NotFound();
            }

            return View(transporter);
        }

        // GET: Transporters/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Transporters/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Location,Destination,Transporting")] Transporter transporter)
        {
            if (ModelState.IsValid)
            {
                _context.Add(transporter);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(transporter);
        }

        // GET: Transporters/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transporter = await _context.Transporter.FindAsync(id);
            if (transporter == null)
            {
                return NotFound();
            }
            return View(transporter);
        }

        // POST: Transporters/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Location,Destination,Transporting")] Transporter transporter)
        {
            if (id != transporter.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(transporter);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TransporterExists(transporter.Id))
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
            return View(transporter);
        }

        // GET: Transporters/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transporter = await _context.Transporter
                .FirstOrDefaultAsync(m => m.Id == id);
            if (transporter == null)
            {
                return NotFound();
            }

            return View(transporter);
        }

        // POST: Transporters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var transporter = await _context.Transporter.FindAsync(id);
            _context.Transporter.Remove(transporter);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TransporterExists(int id)
        {
            return _context.Transporter.Any(e => e.Id == id);
        }
    }
}
