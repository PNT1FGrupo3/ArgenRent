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
    public class PropiedadController : Controller
    {
        private readonly ArgenRentDatabaseContext _context;

        public PropiedadController(ArgenRentDatabaseContext context)
        {
            _context = context;
        }

        // GET: Propiedad
        public async Task<IActionResult> Index()
        {
            var argenRentDatabaseContext = _context.Propiedades.Include(p => p.usuario);
            return View(await argenRentDatabaseContext.ToListAsync());
        }

        // GET: Propiedad/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var propiedad = await _context.Propiedades
                .Include(p => p.usuario)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (propiedad == null)
            {
                return NotFound();
            }

            return View(propiedad);
        }

        // GET: Propiedad/Create
        public IActionResult Create()
        {
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "ID", "apellido");
            //ViewData["TipoPropiedad"] = Enum.GetNames(typeof(TipoPropiedad));
            return View();
        }

        // POST: Propiedad/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,titulo,descripcion,precioPorNoche,aceptaMascotas,cantidadAmbientes,cantidadDormitorios,cantidadBanios,cantidadM2Cubiertos,cantidadM2Descubiertos,cantidadCocheras,ranking,UsuarioId,tipoPropiedad, direccion")] Propiedad propiedad)
        {
            if (ModelState.IsValid)
            {
                _context.Add(propiedad);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "ID", "apellido", propiedad.UsuarioId);
            return View(propiedad);
        }

        // GET: Propiedad/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var propiedad = await _context.Propiedades.FindAsync(id);
            if (propiedad == null)
            {
                return NotFound();
            }
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "ID", "apellido", propiedad.UsuarioId);
            return View(propiedad);
        }

        // POST: Propiedad/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,titulo,descripcion,precioPorNoche,aceptaMascotas,cantidadAmbientes,cantidadDormitorios,cantidadBanios,cantidadM2Cubiertos,cantidadM2Descubiertos,cantidadCocheras,ranking,UsuarioId,tipoPropiedad,direccion")] Propiedad propiedad)
        {
            if (id != propiedad.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(propiedad);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PropiedadExists(propiedad.ID))
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
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "ID", "apellido", propiedad.UsuarioId);
            return View(propiedad);
        }

        // GET: Propiedad/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var propiedad = await _context.Propiedades
                .Include(p => p.usuario)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (propiedad == null)
            {
                return NotFound();
            }

            return View(propiedad);
        }

        // POST: Propiedad/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var propiedad = await _context.Propiedades.FindAsync(id);
            if (propiedad != null)
            {
                _context.Propiedades.Remove(propiedad);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PropiedadExists(int id)
        {
            return _context.Propiedades.Any(e => e.ID == id);
        }
    }
}
