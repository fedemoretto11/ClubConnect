using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ClubConnect.Api.Models.Data;
using ClubConnect.Api.Models.Entidades;
using ClubConnect.Api.Models.Enum;
using ClubConnect.Api.Reglas;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.View;

namespace ClubConnect.Api.Controllers
{
    public class SociosController : Controller
    {
        private readonly DataContext _context;

        public SociosController(DataContext context)
        {
            _context = context;
        }

        // GET: Socios
        public async Task<IActionResult> Index(string nombre, string apellido, int numeroSocio, int dni)
        {
            if (_context.Socios == null)
            {
                return Problem("Entity SociosController.Socio is null");
            }
            var socios = from s in _context.Socios select s;

            if (!String.IsNullOrEmpty(nombre))
            {
                socios = socios.Where(s => s.Nombre!.Contains(nombre));
            }

            if (!String.IsNullOrEmpty(apellido))
            {
                socios = socios.Where(s => s.Apellido!.Contains(apellido));
            }

            if (numeroSocio != 0)
            {
                socios = socios.Where(s => s.Id!.Equals(numeroSocio));
            }

            if (dni != 0)
            {
                socios = socios.Where(s => s.Dni.Equals(dni));
            }

            return View(await socios.ToListAsync());    
              
        }

        // GET: Socios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Socios == null)
            {
                return NotFound();
            }

            var socio = await _context.Socios
                .FirstOrDefaultAsync(m => m.Id == id);
            if (socio == null)
            {
                return NotFound();
            }

            return View(socio);
        }

        // GET: Socios/Create
        public IActionResult Create()
        {
            var socio = new Socio();
            socio.FechaDeNacimiento = new DateTime(1990, 1, 1);
            
            
        
            return View(socio);
        }

        // POST: Socios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Dni,Nombre,Apellido,Direccion,Telefono,Email,Categoria,FechaDeNacimiento")] Socio socio)
        {

            if (ModelState.IsValid)
            {
                // Ver porque no funciona
                //var socioExistente = await RNSocio.BuscarSocio(_context, socio.Id);
                var socioExistente = await _context.Socios.FirstOrDefaultAsync(s => s.Dni == socio.Dni || s.Email == socio.Email);
                if (socioExistente != null)
                {
                    if (socioExistente.EstaActivo == SociosEnum.EstaActivo.SI)
                    {
                        ModelState.AddModelError(string.Empty, "Ya existe un socio con el mismo Dni o Email.");
                    }
                    if (socioExistente.EstaActivo == SociosEnum.EstaActivo.NO)
                    {
                        ModelState.AddModelError(string.Empty, "Ya existe un socio dado de baja con el mismo Dni o Email.");
                    }
                    return View(socio);
                }
                socio.FechaDeRegistro = DateTime.Now;
                socio.EstaActivo = SociosEnum.EstaActivo.SI;
                

                try
                {
                    _context.Add(socio);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));

                }
                catch (DbUpdateException ex)
                {
                    ModelState.AddModelError(string.Empty, "Ocurrió un error al guardar los datos en la base de datos.");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(string.Empty, "Ocurrió un error inesperado.");
                }
            }
            return View(socio);
        }

        // GET: Socios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Socios == null)
            {
                return NotFound();
            }

            var socio = await _context.Socios.FindAsync(id);
            if (socio == null)
            {
                return NotFound();
            }
            return View(socio);
        }

        // POST: Socios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Dni,Nombre,Apellido,Direccion,Telefono,Email,Categoria,EstaActivo,FechaDeNacimiento,FechaDeRegistro")] Socio socio)
        {
            if (id != socio.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(socio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SocioExists(socio.Id))
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
            return View(socio);
        }

        // GET: Socios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Socios == null)
            {
                return NotFound();
            }

            var socio = await _context.Socios
                .FirstOrDefaultAsync(m => m.Id == id);
            if (socio == null)
            {
                return NotFound();
            }

            return View(socio);
        }

        // POST: Socios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Socios == null)
            {
                return Problem("Entity set 'DataContext.Socios'  is null.");
            }
            var socio = await _context.Socios.FindAsync(id);
            if (socio != null)
            {
                // Da de baja no elimina

                //_context.Socios.Remove(socio);
                socio.EstaActivo = Models.Enum.SociosEnum.EstaActivo.NO;
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SocioExists(int id)
        {
          return (_context.Socios?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
