using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ArgenRent.Context;
using ArgenRent.Models;

namespace ArgenRent.Controllers
{
    public class AlquilerController : Controller
    {
        private readonly ArgenRentDatabaseContext _context;

        public AlquilerController(ArgenRentDatabaseContext context)
        {
            _context = context;
        }

        // GET: Alquiler
        public async Task<IActionResult> Index()
        {
            var argenRentDatabaseContext = _context.Alquileres.Include(a => a.propiedad).Include(a => a.usuario);
            return View(await argenRentDatabaseContext.ToListAsync());
        }

        // GET: Alquiler/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alquiler = await _context.Alquileres
                .Include(a => a.propiedad)
                .Include(a => a.usuario)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (alquiler == null)
            {
                return NotFound();
            }

            return View(alquiler);
        }

        // GET: Alquiler/Create
        public IActionResult Create()
        {
            ViewData["PropiedadId"] = new SelectList(_context.Propiedades, "ID", "descripcion");
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "ID", "apellido");
            return View();
        }

        // POST: Alquiler/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,fechaInicio,fechaSalida,PropiedadId,UsuarioId")] Alquiler alquiler)
        {
            if (ModelState.IsValid)
            {
                _context.Add(alquiler);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PropiedadId"] = new SelectList(_context.Propiedades, "ID", "descripcion", alquiler.PropiedadId);
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "ID", "apellido", alquiler.UsuarioId);
            return View(alquiler);
        }

        // GET: Alquiler/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alquiler = await _context.Alquileres.FindAsync(id);
            if (alquiler == null)
            {
                return NotFound();
            }
            ViewData["PropiedadId"] = new SelectList(_context.Propiedades, "ID", "descripcion", alquiler.PropiedadId);
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "ID", "apellido", alquiler.UsuarioId);
            return View(alquiler);
        }

        // POST: Alquiler/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,fechaInicio,fechaSalida,PropiedadId,UsuarioId")] Alquiler alquiler)
        {
            if (id != alquiler.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(alquiler);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AlquilerExists(alquiler.ID))
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
            ViewData["PropiedadId"] = new SelectList(_context.Propiedades, "ID", "descripcion", alquiler.PropiedadId);
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "ID", "apellido", alquiler.UsuarioId);
            return View(alquiler);
        }

        // GET: Alquiler/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alquiler = await _context.Alquileres
                .Include(a => a.propiedad)
                .Include(a => a.usuario)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (alquiler == null)
            {
                return NotFound();
            }

            return View(alquiler);
        }

        // POST: Alquiler/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var alquiler = await _context.Alquileres.FindAsync(id);
            if (alquiler != null)
            {
                _context.Alquileres.Remove(alquiler);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AlquilerExists(int id)
        {
            return _context.Alquileres.Any(e => e.ID == id);
        }
    }
}
